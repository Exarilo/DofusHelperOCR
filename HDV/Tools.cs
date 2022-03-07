using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Tesseract;
using System.Drawing.Imaging;
using System.IO;
using System.Threading;

namespace HDV
{
    class Tools
    {
        #region mouse events
        [DllImport("user32.dll", CharSet = CharSet.Auto, CallingConvention = CallingConvention.StdCall)]
        private static extern int mouse_event(int dwFlags, int dx, int dy, int dwData, int dwExtraInfo);
        [System.Runtime.InteropServices.DllImport("user32")]

        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool SetWindowPos(IntPtr hWnd, IntPtr hWndInsertAfter, int X, int Y, int cx, int cy, uint uFlags);

        private static readonly IntPtr HWND_TOPMOST = new IntPtr(-1);
        private const UInt32 SWP_NOSIZE = 0x0001;
        private const UInt32 SWP_NOMOVE = 0x0002;
        private const UInt32 TOPMOST_FLAGS = SWP_NOMOVE | SWP_NOSIZE;

        //Mouse actions
        private const int MOUSEEVENTF_LEFTDOWN = 0x02;
        private const int MOUSEEVENTF_LEFTUP = 0x04;
        private const int MOUSEEVENTF_RIGHTDOWN = 0x08;
        private const int MOUSEEVENTF_RIGHTUP = 0x10;

        private const int MIDDLEDOWN = 0x20; /*middle button down */
        private const int MIDDLEUP = 0x40; /* middle button up */
        const int MOUSEEVENTF_WHEEL = 0x0800;

        public class Win32
        {
            [DllImport("User32.dll", SetLastError = false)]
            public static extern IntPtr GetDesktopWindow();
            [DllImport("User32.Dll")]
            public static extern long SetCursorPos(int x, int y);

            [DllImport("User32.Dll")]
            public static extern bool ClientToScreen(IntPtr hWnd, ref POINT point);

            [StructLayout(LayoutKind.Sequential)]
            public struct POINT
            {
                public int x;
                public int y;

                public POINT(int X, int Y)
                {
                    x = X;
                    y = Y;
                }
            }
        }
        #endregion

        public Tools()
        {

        }
        public static void moveCursorThanClick(int x, int y, int timeBetweenActionMs)
        {
            moveCursor(x, y);
            doMouseClick();
            Thread.Sleep(timeBetweenActionMs);
        }

        public static void moveCursor(int x, int y)
        {
            Win32.POINT p = new Win32.POINT(x, y);
            Win32.ClientToScreen(Win32.GetDesktopWindow(), ref p);
            Win32.SetCursorPos(p.x, p.y);

        }

        public static void doMouseClick()
        {
            int X = (int)Cursor.Position.X;
            int Y = (int)Cursor.Position.Y;
            mouse_event(MOUSEEVENTF_LEFTDOWN | MOUSEEVENTF_LEFTUP, X, Y, 0, 0);

        }
        public static void captureScreen(string fileName, int x, int y, int width, int height)
        {
            Rectangle rect = new Rectangle(x, y, width, height);
            Bitmap bmp = new Bitmap(rect.Width, rect.Height, PixelFormat.Format32bppArgb);
            Graphics g = Graphics.FromImage(bmp);
            g.CopyFromScreen(rect.Left, rect.Top, 0, 0, bmp.Size, CopyPixelOperation.SourceCopy);
            bmp.Save(fileName, System.Drawing.Imaging.ImageFormat.Jpeg);

        }

        public static void saveBitmap(Bitmap bitmap, string imgPath)
        {
 


            if (File.Exists("saveBitmap.jpg"))
                File.Delete("saveBitmap.jpg");
            bitmap.Save("saveBitmap.jpg", System.Drawing.Imaging.ImageFormat.Jpeg);
            bitmap.Dispose();
            File.Delete(imgPath); // Delete the existing file if exists
            //File.Move(oldFileName, newFileName); // 
            File.Move("saveBitmap.jpg", imgPath);

        }


        public static string getNumberFromImg(string imgPath)
        {

            if (string.IsNullOrEmpty(imgPath))
            {
                throw new ArgumentException($"'{nameof(imgPath)}' cannot be null or empty.", nameof(imgPath));
            }

            using (var engine = new TesseractEngine(@"tessdata/", "eng"))
            {

                engine.SetVariable("tessedit_char_whitelist", "0123456789");
                engine.SetVariable("tessedit_char_blacklis", "$%^*={};<>\\~`");
                engine.SetVariable("matcher_avg_noise_size", "1");
                engine.SetVariable("textord_heavy_nr", "true");

                using (var img = Pix.LoadFromFile(imgPath))
                using (var page = engine.Process(img, Tesseract.PageSegMode.SingleLine))
                using (var iterator = page.GetIterator())
                {
                    Console.WriteLine(page.GetText());
                    iterator.Begin();

                    do
                    {
                        var text = iterator.GetText(Tesseract.PageIteratorLevel.Word);
                        if (text == null)
                            return "-1";
                        if (text.Contains(" "))
                            return "";
                        if (text != null)
                            text = text.Trim(' ');
                        else
                            text = "";
                        return text;
                    }
                    while (iterator.Next(Tesseract.PageIteratorLevel.Word));
                }
            }
        }

        public static string getTextFromImg(string imgPath)
        {

            if (string.IsNullOrEmpty(imgPath))
            {
                throw new ArgumentException($"'{nameof(imgPath)}' cannot be null or empty.", nameof(imgPath));
            }

            using (var engine = new TesseractEngine(@"tessdata/", "eng"))
            {

                engine.SetVariable("tessedit_char_whitelist", "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyzéèôâïÉÈ ");
                engine.SetVariable("tessedit_char_blacklis", "$%^*={};<>\\~`");
                engine.SetVariable("matcher_avg_noise_size", "1");
                engine.SetVariable("textord_heavy_nr", "true");

                using (var img = Pix.LoadFromFile(imgPath))
                using (var page = engine.Process(img, Tesseract.PageSegMode.SingleLine))
                using (var iterator = page.GetIterator())
                {
                    Console.WriteLine(page.GetText());
                    iterator.Begin();

                    do
                    {
                        var text = iterator.GetText(Tesseract.PageIteratorLevel.TextLine);
                        if (text == null)
                            return "";
                        string newString = "";
                        bool isStat = false;
                        for (int i = 0; i < text.Length; i++)
                        {
                            if (text[i] == ' ')
                                isStat = true;
                            if (isStat)
                                newString += text[i];
                        }
                        text = text.Trim('\n');
                        return text;
                    }
                    while (iterator.Next(Tesseract.PageIteratorLevel.TextLine));
                }
            }
        }
        public static string convertImgNumberToText(string imgPath)
        {

            if (string.IsNullOrEmpty(imgPath))
            {
                throw new ArgumentException($"'{nameof(imgPath)}' cannot be null or empty.", nameof(imgPath));
            }

            using (var engine = new TesseractEngine(@"tessdata/", "eng"))
            {

                engine.SetVariable("tessedit_char_whitelist", "0123456789");
                engine.SetVariable("tessedit_char_blacklis", "$%^*={};<>\\~`");
                engine.SetVariable("matcher_avg_noise_size", "1");
                engine.SetVariable("textord_heavy_nr", "true");

                using (var img = Pix.LoadFromFile(imgPath))
                using (var page = engine.Process(img, Tesseract.PageSegMode.SingleLine))
                using (var iterator = page.GetIterator())
                {
                    Console.WriteLine(page.GetText());
                    iterator.Begin();

                    do
                    {
                        var text = iterator.GetText(Tesseract.PageIteratorLevel.Word);
                        return text;
                    }
                    while (iterator.Next(Tesseract.PageIteratorLevel.Word));
                }
            }
        }

        public static string convertImgToText(string imgPath)
        {
            if (string.IsNullOrEmpty(imgPath))
            {
                throw new ArgumentException($"'{nameof(imgPath)}' cannot be null or empty.", nameof(imgPath));
            }

            string res = "";
            using (var engine = new TesseractEngine(@"tessdata", "eng", EngineMode.Default))
            {
                engine.SetVariable("tessedit_char_whitelist", "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyzéèôâïÉÈ ");
                engine.SetVariable("tessedit_char_blacklis", "$%^*={};<>\\~`");
                engine.SetVariable("matcher_avg_noise_size", "1");

                engine.SetVariable("textord_heavy_nr", "true");
                //engine.SetVariable("image_default_resolution", "450");

                using (var img = Pix.LoadFromFile(imgPath))
                using (var page = engine.Process(img, Tesseract.PageSegMode.SingleLine))
                    res = page.GetText();
                res = res.Replace("\n", "");
            }
            return res;

        }
        public static void binarizeimg(string imgPath, int RGBpixelsToBinarize)
        {
            Bitmap curBitmap = new Bitmap(imgPath);


            if (curBitmap != null)
            {
                Color curColor;
                int ret;
                for (int iX = 0; iX < curBitmap.Width; iX++)
                {
                    for (int iY = 0; iY < curBitmap.Height; iY++)
                    {
                        curColor = curBitmap.GetPixel(iX, iY);
                        ret = (int)(curColor.R * 0.299 + curColor.G * 0.578 + curColor.B * 0.114);
                        // This is our threshold, you can change it and to try what are different.
                        if (ret > RGBpixelsToBinarize)
                        {
                            ret = 0;
                        }
                        else
                        {
                            ret = 255;
                        }
                        curBitmap.SetPixel(iX, iY, Color.FromArgb(ret, ret, ret));
                    }
                }

                Tools.saveBitmap(curBitmap, imgPath);
            }
        }
    }


}
