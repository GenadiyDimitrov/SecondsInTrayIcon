using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SecondsTryApp
{
    public partial class FullForm : Form
    {
        Microsoft.Win32.RegistryKey autorun;
        string autoRunName = "Windows11SecondsTryIconApp";
        public FullForm()
        {
            InitializeComponent();
            autorun = Microsoft.Win32.Registry.CurrentUser.OpenSubKey(@"SOFTWARE\Microsoft\Windows\CurrentVersion\Run", true);
            FormClosed += FullForm_FormClosed;
        }

        private void FullForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Program.OnTimerTick -= TimerTick;
        }
        public void Open()
        {
            Program.OnTimerTick -= TimerTick;
            Program.OnTimerTick += TimerTick;
            if (autorun.GetValue(autoRunName) != null)
            {
                autoRunBtn.BackColor = Color.Green;
            }
            else
            {
                autoRunBtn.BackColor = Color.Red;
            }

            this.ShowDialog();
        }

        private void TimerTick()
        {
            timeLabel.Text = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
        }

        private void autoRunBtn_Click(object sender, EventArgs e)
        {
            CheckButtonState(true);
        }
        private void CheckButtonState(bool save)
        {
            if (autorun.GetValue(autoRunName) != null)
            {
                if (save) autorun.DeleteValue(autoRunName, false);
                autoRunBtn.BackColor = Color.Red;
            }
            else
            {
                if (save) autorun.SetValue(autoRunName, Application.ExecutablePath);
                autoRunBtn.BackColor = Color.Green;
            }
        }
    }
}
