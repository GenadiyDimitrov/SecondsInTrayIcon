using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Resources;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SecondsTryApp
{
    internal static class Program
    {
        public delegate void TimerTickEvent();
        public static TimerTickEvent OnTimerTick;

        static readonly Timer Timer = new Timer();
        static readonly NotifyIcon AppIcon = new NotifyIcon();
        private static FullForm _FullForm;
        private static ResourceManager ResourceManager;

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Icons.GenerateIcons();

            //fill fields
            ResourceManager = new ResourceManager(typeof(Properties.Resources));
            _FullForm = new FullForm();

            //Context menu
            ContextMenu contextMenu = new ContextMenu();
            MenuItem contextItemOpen = new MenuItem();
            MenuItem contextItemExit = new MenuItem();
            contextItemOpen.Text = "&Отвори";
            contextItemExit.Text = "&Изход";
            contextItemOpen.Click += new EventHandler(contextMenuOpen_Click);
            contextItemExit.Click += new EventHandler(contextMenuExit_Click);
            contextMenu.MenuItems.Add(contextItemOpen);
            contextMenu.MenuItems.Add(contextItemExit);
            AppIcon.ContextMenu = contextMenu;

            //app additional data
            UpdateIcon();
            AppIcon.Visible = true;
            AppIcon.MouseClick += new MouseEventHandler(AppIcon_MouseClick);

            //timer
            Timer.Interval = 500;
            Timer.Tick += Timer_Tick;
            Timer.Start();

            //Launch
            Application.Run();
        }
        private static void Timer_Tick(object sender, EventArgs e)
        {
            try
            {
                UpdateIcon();
                OnTimerTick?.Invoke();
            }
            catch (Exception ex)
            {
            }
        }
        private static void UpdateIcon()
        {
            AppIcon.Icon = Icons.Data[DateTime.Now.Second];
        }
        private static void AppIcon_MouseClick(object sender, MouseEventArgs e)
        {
            Open();
        }
        private static void contextMenuOpen_Click(object sender, System.EventArgs e)
        {
            Open();
        }
        private static void Open()
        {
            //check if not already opened else open
            if (!_FullForm.Visible) _FullForm.Open();
        }
        private static void contextMenuExit_Click(object sender, System.EventArgs e)
        {
            //exit the app
            Application.Exit();
        }
    }
}
