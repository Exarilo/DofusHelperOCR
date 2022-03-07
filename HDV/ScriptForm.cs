using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;

namespace HDV
{
    public partial class ScriptForm : Form
    {
        [DllImport("user32.dll", CharSet = CharSet.Auto, CallingConvention = CallingConvention.StdCall)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool SetWindowPos(IntPtr hWnd, IntPtr hWndInsertAfter, int X, int Y, int cx, int cy, uint uFlags);

        private static readonly IntPtr HWND_TOPMOST = new IntPtr(-1);
        private const UInt32 SWP_NOSIZE = 0x0001;
        private const UInt32 SWP_NOMOVE = 0x0002;
        private const UInt32 TOPMOST_FLAGS = SWP_NOMOVE | SWP_NOSIZE;

        public ScriptForm()
        {
            InitializeComponent();
            SetWindowPos(this.Handle, HWND_TOPMOST, 0, 0, 0, 0, TOPMOST_FLAGS);
        }

        private void btMoveCursor_Click(object sender, EventArgs e)
        {
            if (tbCode.Text != "")
                tbCode.Text += "\r\n";

            tbCode.Text += "moveCursor(x,y);";

        }

        private void btMouseClick_Click(object sender, EventArgs e)
        {
            if (tbCode.Text != "")
                tbCode.Text += "\r\n";

            tbCode.Text += "doMouseClick();";
        }

        private void btCaptureScreen_Click(object sender, EventArgs e)
        {
            if (tbCode.Text != "")
                tbCode.Text += "\r\n";

            tbCode.Text += "captureScreen(fileName,x,y,width,height);";
        }

        private void btConvertImgString_Click(object sender, EventArgs e)
        {
            if (tbCode.Text != "")
                tbCode.Text += "\r\n";

            tbCode.Text += "convertImgToText(fileName);";


        }

        private void btConvertImgInt_Click(object sender, EventArgs e)
        {
            if (tbCode.Text != "")
                tbCode.Text += "\r\n";

            tbCode.Text += "convertImgNumberToText(fileName);";
        }

        private void btWait_Click(object sender, EventArgs e)
        {
            if (tbCode.Text != "")
                tbCode.Text += "\r\n";

            tbCode.Text += "Thread.Sleep(secondes);";

        }

        private void btSaveConfig_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(tbCode.Text))
            {
                MessageBox.Show("Impossible to save an empty code");
                return;
            }
            if (String.IsNullOrWhiteSpace(tbConfigName.Text))
            {
                MessageBox.Show("Please choose a name for this configuration");
                return;
            }
            string path = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().GetName().CodeBase);
            path = path.Substring(6);
            if (File.Exists(path + tbConfigName.Text + ".txt"))
            {
                DialogResult dialogResult = MessageBox.Show("A config with the same name already exist do you want to replace it ?", "Existing file", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    File.WriteAllText(tbConfigName.Text + ".txt", tbCode.Text);
                }
                else if (dialogResult == DialogResult.No)
                {
                    MessageBox.Show("Save canceled successfully");
                }
            }
            File.WriteAllText(tbConfigName.Text + ".txt", tbCode.Text);
        }

        private void btSaveConfig_Click_1(object sender, EventArgs e)
        {

        }
    }
}
