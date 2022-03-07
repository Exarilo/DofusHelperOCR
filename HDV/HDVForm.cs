using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using System.IO;
using System.Collections;
using System.Collections.Generic;

namespace HDV
{
    public partial class HDVForm : Form
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

        public HDVForm()
        {
            InitializeComponent();
            gridHDV.Columns.Add("Name", "Name");
            gridHDV.Columns.Add("x1", "x1");
            gridHDV.Columns.Add("x10", "x10");
            gridHDV.Columns.Add("x100", "x100");
            gridHDV.Columns.Add("Profit", "Profit");
            //gridHDV.Columns.Add("Kamas", "Kamas");
            SetWindowPos(this.Handle, HWND_TOPMOST, 0, 0, 0, 0, TOPMOST_FLAGS);
            //cbConfig.SelectedItem = "HDV";
            cbConfig.SelectedIndex = 1;;

            setToolTip();
            /*
            gridHDV.Rows.Add("100", "100", "100", "100", "100%");
            gridHDV.Rows.Add("100", "100", "100", "100", "200%");
            gridHDV.Rows.Add("100", "100", "100", "100", "300%");
            gridHDV.Rows.Add("100", "100", "100", "100", "500%");
            gridHDV.Rows.Add("100", "100", "100", "100", "1000%");
            gridHDV.Rows.Add("100", "100", "100", "100", "20%");
            gridHDV.Rows.Add("100", "100", "100", "100", "10%");
            gridHDV.Rows.Add("100", "100", "100", "100", "1000%");
            for(int i = 0; i < gridHDV.Rows.Count-1; i++)
            {
                setGridColor(i);
            }*/



        }

        #region Work Fine
        #region ToolTip
        public void setToolTip()
        {
            ToolTip toolTip = new ToolTip();
            toolTip.AutoPopDelay = 5000;
            toolTip.InitialDelay = 1500;
            toolTip.ReshowDelay = 500;
            toolTip.ShowAlways = true;
            toolTip.UseFading = true;
            toolTip.UseAnimation = true;
            toolTip.IsBalloon = true;

            toolTip.SetToolTip(this.btStart, "This button lauch the choosen config");
            toolTip.SetToolTip(this.btToCSV, "This button will export all the results of the grid above in an Excel table");
            toolTip.SetToolTip(this.btCursorPosition, "This button will wait 3 seconds than a message will appear in the text box on the right with the cursor location(x,y)");
            toolTip.SetToolTip(this.btCursorPosition, "This button will wait 3 seconds than a message will appear in the text box on the right with the cursor location(x,y)");
            toolTip.SetToolTip(this.btGetRectangleParam, "This button will give after 3 seconds the cursor location (x,y) \nafter 3 others seconds the parameters of the rectangles between the two cursor points (x,y,width,height)\nA message will appear in the text box on the right");
            toolTip.SetToolTip(this.tbResult, "This text box is used to give information after an action");
            toolTip.SetToolTip(this.cbConfig, "This box is used to manage will configuration will be lauch after clicking on the Strat button");


        }
        #endregion





        #region Button
        private void btStart_Click(object sender, EventArgs e)
        {
            if ((string)cbConfig.SelectedItem == "HDV Resources")
                configHDVResources();
            else if ((string)cbConfig.SelectedItem == "HDV Runes")
                configHDVRunes();
            else if ((string)cbConfig.SelectedItem == "Test")
                test();



        }
        public void configHDVRunes()
        {
            Tools.moveCursorThanClick(376, 470, 3000);
            int numberOfItemsPages = 8; //there are 14 items per page
            analyseItem(numberOfItemsPages);
        }

        private void btCursorPosition_Click(object sender, EventArgs e)
        {
            Thread.Sleep(3000);
            tbResult.Text = Cursor.Position.X.ToString() + "," + Cursor.Position.Y.ToString();

        }

        private void btGetRectangleParam_Click(object sender, EventArgs e)
        {
            tbResult.Text = "";
            Thread.Sleep(3000);
            int X1 = Cursor.Position.X;
            int Y1 = Cursor.Position.Y;

            tbResult.Text = X1.ToString() + "," + Y1.ToString();
            tbResult.Refresh();
            Thread.Sleep(3000);
            int X2 = Cursor.Position.X;
            int Y2 = Cursor.Position.Y;

            int Width = X2 - X1;
            int Height = Y2 - Y1;

            tbResult.Text = X1.ToString() + "," + Y1.ToString() + "," + Width.ToString() + "," + Height.ToString();
        }





        private void btToCSV_Click(object sender, EventArgs e)
        {
            var sb = new StringBuilder();

            var headers = gridHDV.Columns.Cast<DataGridViewColumn>();
            sb.AppendLine(string.Join(";", headers.Select(column => "\"" + column.HeaderText + "\"").ToArray()));

            foreach (DataGridViewRow row in gridHDV.Rows)
            {
                var cells = row.Cells.Cast<DataGridViewCell>();
                sb.AppendLine(string.Join(";", cells.Select(cell => "\"" + cell.Value + "\"").ToArray()));
            }
            File.WriteAllText("test.csv", sb.ToString(), Encoding.ASCII);
            MessageBox.Show("Exported succefully !");
        }
        #endregion



        #region Config HDV
        public void configHDVResources()
        {

            int numberOfCategoryPages = 1; //there are 22 categories per page

            //int numberOfCategoryPages = 3; //there are 22 categories per page
            int numberOfItemsPages = 5; //there are 14 items per page


            checkCategory(numberOfCategoryPages);
            analyseItem(numberOfItemsPages);


        }

        #endregion
        #endregion

        #region Config Test
        public void test()
        {
            int x = 0;
            int y = 0;
            for(int j=0;j< 1080; j++)
            {
                for (int i = 0; i < 1920; i++)
                {
                    Tools.moveCursor(x + i, y+j);
                    Thread.Sleep(10);

                }
            }
        }
        #endregion

        #region To Change
        private void cbConfig_SelectedIndexChanged(object sender, EventArgs e)
        {
            if ((string)cbConfig.SelectedItem == "Programmer")
            {
                ScriptForm scriptForm = new ScriptForm();
                scriptForm.ShowDialog();
            }

        }
        #endregion


        #region DataGrid Color
        public void setGridColor(int roxIndex)
        {
            string value = gridHDV.Rows[roxIndex].Cells[4].Value.ToString();
            if (value == "Error" || value.Contains("Maybe an Error"))
            {
                gridHDV.Rows[roxIndex].Cells[4].Style.BackColor = ColorTranslator.FromHtml("#FC2DFF");
                gridHDV.Refresh();
                return;
            }

            int profitValue = Convert.ToInt32(value.Remove(value.Length - 1));
            if (profitValue <= 0)
                gridHDV.Rows[roxIndex].Cells[4].Style.BackColor = ColorTranslator.FromHtml("#FF2D00");
            else if (profitValue > 0 && profitValue <= 20)
                gridHDV.Rows[roxIndex].Cells[4].Style.BackColor = ColorTranslator.FromHtml("#E34D2D");
            else if (profitValue > 20 && profitValue <= 40)
                gridHDV.Rows[roxIndex].Cells[4].Style.BackColor = ColorTranslator.FromHtml("#DC933B");
            else if (profitValue > 40 && profitValue <= 60)
                gridHDV.Rows[roxIndex].Cells[4].Style.BackColor = ColorTranslator.FromHtml("#CDDC3B");
            else if (profitValue > 60 && profitValue <= 80)
                gridHDV.Rows[roxIndex].Cells[4].Style.BackColor = ColorTranslator.FromHtml("#9DDC3B");
            else if (profitValue >= 100)
                gridHDV.Rows[roxIndex].Cells[4].Style.BackColor = ColorTranslator.FromHtml("#9BFF00");
            gridHDV.FirstDisplayedScrollingRowIndex = gridHDV.Rows.Count - 1;
            gridHDV.Refresh();


        }

        #endregion
        /*
        public string calculKamas(string quantity1, string quantity10, string quantity100)
        {
            if (quantity1 == "0" || quantity10 == "0" || quantity100 == "0")
                return "Error";
            int qt1;
            int qt10;
            int qt100;
            List<int> listQuantity = new List<int>();


            bool successQt1 = int.TryParse(quantity1, out qt1); ;
            if (successQt1)
                listQuantity.Add(qt1 * 100);
            bool successQt10 = int.TryParse(quantity10, out qt10); ;
            if (successQt10)
                listQuantity.Add(qt10 * 10);
            bool successQt100 = int.TryParse(quantity100, out qt100); ;
            if (successQt100)
                listQuantity.Add(qt100);
            if (listQuantity.Count <= 1)
                return "Error";
            listQuantity.Sort();

            double kamaDouble;
            if (listQuantity.Count == 3)
                kamaDouble = Math.Round((((double)listQuantity[2] - (double)listQuantity[0])));

            else
                kamaDouble = Math.Round((double)listQuantity[1] - (double)listQuantity[0]);

            string kamas= kamas = kamaDouble.ToString() + "K";
            return kamas;
        }*/
        public String calculProfit(string quantity1, string quantity10, string quantity100)
        {
            if (quantity1 == "0" || quantity10 == "0" || quantity100 == "0")
                return "Error";
            int qt1;
            int qt10;
            int qt100;
            List<int> listQuantity = new List<int>();


            bool successQt1 = int.TryParse(quantity1, out qt1); ;
            if (successQt1)
                listQuantity.Add(qt1 * 100);
            bool successQt10 = int.TryParse(quantity10, out qt10); ;
            if (successQt10)
                listQuantity.Add(qt10 * 10);
            bool successQt100 = int.TryParse(quantity100, out qt100); ;
            if (successQt100)
                listQuantity.Add(qt100);
            if(listQuantity.Count<=1)
                return "Error";
            listQuantity.Sort();

            double profit;
            if (listQuantity.Count == 3)
                profit = Math.Round((((double)listQuantity[2] - (double)listQuantity[0]) / (double)listQuantity[0]) * 100);//*0.98

            else
                profit = Math.Round((((double)listQuantity[1] - (double)listQuantity[0]) / (double)listQuantity[0]) * 100);//*0.9

            string percent = profit.ToString() + "%";
            return percent;
        }
        /*
        public String calculProfit(string quantity1, string quantity10, string quantity100)
        {
            if (quantity1 == "0" || quantity10 == "0" || quantity100 == "0")
                return "Error";

            if (String.IsNullOrEmpty(quantity1) || String.IsNullOrEmpty(quantity10) || String.IsNullOrEmpty(quantity100))
                return "Error";
            int qt1;
            int qt10;
            int qt100;
            try
            {
                qt1 = Convert.ToInt32(quantity1) * 100;
                qt10 = Convert.ToInt32(quantity10) * 10;
                qt100 = Convert.ToInt32(quantity100);
            }
            catch
            {
                return "Error";
            }

            int[] arr = new int[] { qt1, qt10, qt100 };
            Array.Sort(arr);
            double profit = Math.Round((((double)arr[2] - (double)arr[0]) / (double)arr[0]) * 100);//*0.98
            if (profit > 5000)
                return "Maybe an Error";
            string percent = profit.ToString() + "%";
            return percent;
        }*/


        #region Check Category

        public void checkCategory(int numberOfCategoryPages)
        {
            Thread.Sleep(1000);
            mouse_event(MOUSEEVENTF_WHEEL, 0, 0, -120, 0);

            for (int i = 0; i < numberOfCategoryPages; i++)
            {
                mouse_event(MOUSEEVENTF_WHEEL, 0, 0, -700, 0);
                loopCategory(19);
            }

        }

        public void loopCategory(int nbLoop)
        {
            int yInterval = 31;
            int yStart = 189;

            for (int i = 0; i < nbLoop; i++)
            {
                Tools.moveCursor(374, yStart + (yInterval * i));
                Thread.Sleep(300);
                if (i == 0)
                    mouse_event(MOUSEEVENTF_WHEEL, 0, 0, -240, 0);

                Thread.Sleep(300);
                Tools.doMouseClick();
                Thread.Sleep(300);
            }

        }
        #endregion

        #region Analyse Items

        public void analyseItem(int numberOfItemsPages)
        {
            Tools.moveCursor(642, 206);
            mouse_event(MOUSEEVENTF_WHEEL, 0, 0, 5000, 0);

            for (int i = 0; i < numberOfItemsPages; i++)
            {
                analyseItemLoop(1);
                Thread.Sleep(1000);
                mouse_event(MOUSEEVENTF_WHEEL, 0, 0, -500, 0);
            }
        }
        public void analyseItemLoop(int nbLoop)
        {
            int yInterval = 46;
            int yStart = 220;
            string path = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().GetName().CodeBase);
            path = path.Substring(6);

            string textOfScreen1;
            string textOfScreen2;
            string textOfScreen3;
            string textOfScreen4;
            Thread.Sleep(1000);
            for (int i = 0; i < nbLoop; i++)
            {
                Tools.moveCursorThanClick(642, yStart + (yInterval * i), 300);
                Thread.Sleep(500);

                Tools.captureScreen("test.jpg", 665, 217 + (yInterval * i), 113, 25);
                Tools.binarizeimg(path + "\\test.jpg", 75);
                textOfScreen1 = Tools.convertImgToText(path + "\\test.jpg");
                Thread.Sleep(100);

                Tools.captureScreen("test.jpg", 931, 252 + (yInterval * i), 95, yInterval);
                Tools.binarizeimg(path + "\\test.jpg", 75);

                textOfScreen2 = Tools.convertImgNumberToText(path + "\\test.jpg");
                Thread.Sleep(100);

                Tools.captureScreen("test.jpg", 931, 298 + (yInterval * i), 95, yInterval);
                Tools.binarizeimg(path + "\\test.jpg", 75);

                textOfScreen3 = Tools.convertImgNumberToText(path + "\\test.jpg");
                Thread.Sleep(100);

                Tools.captureScreen("test.jpg", 931, 344 + (yInterval * i), 95, yInterval);
                Tools.binarizeimg(path + "\\test.jpg", 75);

                textOfScreen4 = Tools.convertImgNumberToText(path + "\\test.jpg");
                if (isValide(textOfScreen1, textOfScreen2, textOfScreen3, textOfScreen4))
                    gridHDV.Rows.Add(textOfScreen1, textOfScreen2, textOfScreen3, textOfScreen4, calculProfit(textOfScreen2, textOfScreen3, textOfScreen4));
                else
                    continue;
                setGridColor(i);
                gridHDV.Refresh();
                Thread.Sleep(100);

                Tools.moveCursor(642, yStart + (yInterval * i));
                Thread.Sleep(300);
                Tools.doMouseClick();
                Thread.Sleep(500);
            }
        }
        public bool isValide(string str1, string str2, string str3, string str4)
        {
            if (String.IsNullOrEmpty(str1))
                return false;
           // if (str2.Contains(" ") && str3.Contains(" ") && str4.Contains(" ")&&str2!=null && str3 != null && str4 != null)
             //   return false;
            if(String.IsNullOrEmpty(str2) && String.IsNullOrEmpty(str3) && String.IsNullOrEmpty(str4))
                return false;
            if ((String.IsNullOrEmpty(str2) && String.IsNullOrEmpty(str3))|| (String.IsNullOrEmpty(str2) && String.IsNullOrEmpty(str4))|| (String.IsNullOrEmpty(str3) && String.IsNullOrEmpty(str4)))
                return false;


            return true;
        }









        #endregion







        // CAN BE USEFULL


        /*
        public void setLabel(string path)
        {
            Label imgLabel = new Label();
            imgLabel.Image = Image.FromFile(path);
            imgLabel.AutoSize = false;
            imgLabel.Size = imgLabel.Image.Size;
            imgLabel.ImageAlign = ContentAlignment.MiddleCenter;
            imgLabel.Text = "";
            imgLabel.BackColor = Color.Transparent;
            imgLabel.Parent = textBox1;
            // pick a location where it won't get in the way too much
            imgLabel.Location = new System.Drawing.Point(textBox1.ClientSize.Width - imgLabel.Image.Width, 0);
            textBox1.Refresh();
        }*/
        /*
        public void InvertColor(string imgPath)
        {

            Bitmap curBitmap = new Bitmap(imgPath);
            for (int y = 0; (y <= (curBitmap.Height - 1)); y++)
            {
                for (int x = 0; (x <= (curBitmap.Width - 1)); x++)
                {
                    Color inv = curBitmap.GetPixel(x, y);
                    inv = Color.FromArgb(255, (255 - inv.R), (255 - inv.G), (255 - inv.B));
                    curBitmap.SetPixel(x, y, inv);
                }
            }
            saveBitmap(curBitmap, imgPath);
        }*/

        /*
        public string convertImgToText(string imgPath)
        {
            if (string.IsNullOrEmpty(imgPath))
            {
                throw new ArgumentException($"'{nameof(imgPath)}' cannot be null or empty.", nameof(imgPath));
            }

            var Ocr = new IronTesseract();
            using (var Input = new OcrInput(imgPath))
            {
                //Input.Deskew();  // use if image not straight
                //Input.DeNoise(); // use if image contains digital noise
                var Result = Ocr.Read(Input);
                return Result.Text;

            }
        }*/


        /*
        public void analyseItem2()
        {
            int yInterval = 46;
            int yStart = 206;
            string path = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().GetName().CodeBase);
            path = path.Substring(6);

            string textOfScreen1;
            string textOfScreen2;
            string textOfScreen3;
            string textOfScreen4;

            for (int i = 0; i < 14; i++)
            {
                moveCursor(642, yStart + (yInterval * i));
                Thread.Sleep(300);
                doMouseClick();
                Thread.Sleep(500);


                captureScreen("test.jpg", 665, 217 + (yInterval * i), 113, 25);
                binarizeimg(path + "\\test.jpg");
                textOfScreen1 = convertImgToText(path + "\\test.jpg");
                Thread.Sleep(100);

                captureScreen("test.jpg", 960, 252 + (yInterval * i), 68, yInterval);
                binarizeimg(path + "\\test.jpg");

                textOfScreen2 = convertImgNumberToText(path + "\\test.jpg");
                Thread.Sleep(100);

                captureScreen("test.jpg", 960, 298 + (yInterval * i), 68, yInterval);
                binarizeimg(path + "\\test.jpg");

                textOfScreen3 = convertImgNumberToText(path + "\\test.jpg");
                Thread.Sleep(100);

                captureScreen("test.jpg", 960, 344 + (yInterval * i), 68, yInterval);
                binarizeimg(path + "\\test.jpg");

                textOfScreen4 = convertImgNumberToText(path + "\\test.jpg");
                gridHDV.Rows.Add(textOfScreen1, textOfScreen2, textOfScreen3, textOfScreen4, calculProfit(textOfScreen2, textOfScreen3, textOfScreen4));
                setGridColor(i);
                gridHDV.Refresh();
                Thread.Sleep(100);
                moveCursor(642, yStart + (yInterval * i));
                Thread.Sleep(300);
                doMouseClick();
                Thread.Sleep(500);
            }


        }*/

    }


}
