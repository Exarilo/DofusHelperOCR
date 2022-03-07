using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace HDV
{
    public partial class DirectionForm : Form
    {
        [System.Runtime.InteropServices.DllImport("user32")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool SetWindowPos(IntPtr hWnd, IntPtr hWndInsertAfter, int X, int Y, int cx, int cy, uint uFlags);
        private static readonly IntPtr HWND_TOPMOST = new IntPtr(-1);
        private const UInt32 SWP_NOSIZE = 0x0001;
        private const UInt32 SWP_NOMOVE = 0x0002;
        private const UInt32 TOPMOST_FLAGS = SWP_NOMOVE | SWP_NOSIZE;
        public DirectionForm()
        {
            InitializeComponent();
            SetWindowPos(this.Handle, HWND_TOPMOST, 0, 0, 0, 0, TOPMOST_FLAGS);
            /*Tools.captureScreen("pos.jpg", 0, 71, 30, 32);
            Tools.binarizeimg("pos.jpg", 150);
            int posX;
            Thread.Sleep(2000);
            bool successX =int.TryParse(Tools.convertImgNumberToText("pos.jpg"), out posX); ;
            if (successX)
                currentPositionX.Value = posX;


            Tools.captureScreen("pos.jpg", 45, 71, 36, 32);
            Tools.binarizeimg("pos.jpg", 190);
            int posY;
            bool successY = int.TryParse(Tools.convertImgNumberToText("pos.jpg"), out posY); ;
            if (successY)
                currentPositionY.Value = posY;*/

        }

        public string setDirectionX()
        {
            string directionX;

            if (currentPositionX.Value > destinationPositionX.Value)
                directionX = "Left";
            else if (currentPositionX.Value < destinationPositionX.Value)
                directionX = "Right";
            else
                directionX = "No Move";

            return directionX;
        }
        public string setDirectionY()
        {
            string directionY;

            if (currentPositionY.Value > destinationPositionY.Value)
                directionY = "Up";

            else if (currentPositionY.Value < destinationPositionY.Value)
                directionY = "Down";
            else
                directionY = "No Move";
            return directionY;
        }
        public int setNbMapX()
        {
            int nbMapX;
            if ((int)Math.Abs(currentPositionX.Value) > (int)Math.Abs(destinationPositionX.Value))
                nbMapX = (int)Math.Abs(currentPositionX.Value) - (int)Math.Abs(destinationPositionX.Value);
            else
                nbMapX = (int)Math.Abs(destinationPositionX.Value) - (int)Math.Abs(currentPositionX.Value);
            return nbMapX;
        }
        public int setNbMapY()
        {
            int nbMapY;
            if ((int)Math.Abs(currentPositionY.Value) > (int)Math.Abs(destinationPositionY.Value))
                nbMapY = (int)Math.Abs(currentPositionY.Value) - (int)Math.Abs(destinationPositionY.Value);
            else
                nbMapY = (int)Math.Abs(destinationPositionY.Value) - (int)Math.Abs(currentPositionY.Value);
            return nbMapY;
        }
        private void btStart_Click(object sender, EventArgs e)
        {
            string directionX, directionY;
            int nbMapX, nbMapY;

            directionX = setDirectionX();
            directionY = setDirectionY();

            nbMapX = setNbMapX();
            nbMapY = setNbMapY();

            MoveX(directionX, nbMapX);
            Thread.Sleep(8000);
            MoveY(directionY, nbMapY);

        }
        public void MoveX(string direction, int nbMap)
        {
            Random rand = new Random();
            bool isFirsTime = true;
            switch (direction)
            {
                case "Left":
                    while (nbMap != 0)
                    {
                        currentPositionX.Refresh();
                        int XLeft = rand.Next(50, 352);
                        int YLeft = rand.Next(40, 819);
                        if (!isFirsTime)
                            Thread.Sleep(8000);
                        Tools.moveCursorThanClick(XLeft, YLeft, 300);
                        nbMap -= 1;
                        currentPositionX.Value -= 1;
                        isFirsTime = false;
                    }
                    break;
                case "Right":
                    while (nbMap != 0)
                    {
                        currentPositionX.Refresh();
                        int XRight = rand.Next(1577, 1920);
                        int YRight = rand.Next(106, 819);
                        if (!isFirsTime)
                            Thread.Sleep(8000);
                        Tools.moveCursorThanClick(XRight, YRight, 300);
                        nbMap -= 1;
                        currentPositionX.Value += 1;
                        isFirsTime = false;
                    }
                    break;
                default:
                    break;
            }


        }
        public void MoveY(string direction, int nbMap)
        {
            Random rand = new Random();
            bool isFirsTime = true;
            switch (direction)
            {
                case "Up":
                    while (nbMap != 0)
                    {
                        currentPositionX.Refresh();
                        int XUp = rand.Next(0, 1795);
                        int YUp = rand.Next(27, 38);
                        if (!isFirsTime)
                            Thread.Sleep(8000);
                        Tools.moveCursorThanClick(XUp, YUp, 300);
                        nbMap -= 1;
                        currentPositionY.Value -= 1;
                        isFirsTime = false;
                    }
                    break;
                case "Down":
                    while (nbMap != 0)
                    {
                        currentPositionX.Refresh();
                        int XDown = rand.Next(432, 1250);
                        int YDown = rand.Next(907, 911);

                        if (!isFirsTime)
                            Thread.Sleep(8000);
                        Tools.moveCursorThanClick(XDown, YDown, 300);
                        nbMap -= 1;
                        currentPositionY.Value += 1;
                        isFirsTime = false;
                    }
                    break;
                default:
                    break;
            }

        }
    }
}
