using System.Drawing;

namespace SecondsTryApp
{
    public static class Icons
    {
        public static Icon[] Data = new Icon[60];
        public static void GenerateIcons()
        {
            for (int i = 0; i < 60; i++)
            {
                Data[i] = GetIcon($"{i:00}");
            }
        }
        private static Icon GetIcon(string text)
        {
            //Create bitmap, kind of canvas
            Bitmap bitmap = new Bitmap(64, 64);

            Icon icon = new Icon(@"Resources\00.ico");
            System.Drawing.Font drawFont = new System.Drawing.Font("Arial", 48, FontStyle.Bold);
            System.Drawing.SolidBrush drawBrush = new System.Drawing.SolidBrush(System.Drawing.Color.White);

            System.Drawing.Graphics graphics = System.Drawing.Graphics.FromImage(bitmap);

            graphics.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SingleBitPerPixel;
            graphics.DrawIcon(icon, 0, 0);
            graphics.DrawString(text, drawFont, drawBrush, -14, -10);

            //To Save icon to disk
            bitmap.Save("icon.ico", System.Drawing.Imaging.ImageFormat.Icon);

            Icon createdIcon = Icon.FromHandle(bitmap.GetHicon());

            drawFont.Dispose();
            drawBrush.Dispose();
            graphics.Dispose();
            bitmap.Dispose();

            return createdIcon;
        }
    }
}
