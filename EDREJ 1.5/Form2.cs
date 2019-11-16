using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EDREJ_1._5
{
    public partial class Form2 : Form
    {
        //---The shadow and the movement forms---\\
        private bool Drag;
        private int MouseX;
        private int MouseY;

        private const int WM_NCHITTEST = 0x84;
        private const int HTCLIENT = 0x1;
        private const int HTCAPTION = 0x2;

        private bool m_aeroEnabled;

        private const int CS_DROPSHADOW = 0x00020000;
        private const int WM_NCPAINT = 0x0085;
        private const int WM_ACTIVATEAPP = 0x001C;

        [System.Runtime.InteropServices.DllImport("dwmapi.dll")]
        public static extern int DwmExtendFrameIntoClientArea(IntPtr hWnd, ref MARGINS pMarInset);
        [System.Runtime.InteropServices.DllImport("dwmapi.dll")]
        public static extern int DwmSetWindowAttribute(IntPtr hwnd, int attr, ref int attrValue, int attrSize);
        [System.Runtime.InteropServices.DllImport("dwmapi.dll")]

        public static extern int DwmIsCompositionEnabled(ref int pfEnabled);
        [System.Runtime.InteropServices.DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(
            int nLeftRect,
            int nTopRect,
            int nRightRect,
            int nBottomRect,
            int nWidthEllipse,
            int nHeightEllipse
            );

        public struct MARGINS
        {
            public int leftWidth;
            public int rightWidth;
            public int topHeight;
            public int bottomHeight;
        }
        protected override CreateParams CreateParams
        {
            get
            {
                m_aeroEnabled = CheckAeroEnabled();
                CreateParams cp = base.CreateParams;
                if (!m_aeroEnabled)
                    cp.ClassStyle |= CS_DROPSHADOW; return cp;
            }
        }
        private bool CheckAeroEnabled()
        {
            if (Environment.OSVersion.Version.Major >= 6)
            {
                int enabled = 0; DwmIsCompositionEnabled(ref enabled);
                return (enabled == 1) ? true : false;
            }
            return false;
        }
        protected override void WndProc(ref Message m)
        {
            switch (m.Msg)
            {
                case WM_NCPAINT:
                    if (m_aeroEnabled)
                    {
                        var v = 2;
                        DwmSetWindowAttribute(this.Handle, 2, ref v, 4);
                        MARGINS margins = new MARGINS()
                        {
                            bottomHeight = 1,
                            leftWidth = 0,
                            rightWidth = 0,
                            topHeight = 0
                        }; DwmExtendFrameIntoClientArea(this.Handle, ref margins);
                    }
                    break;
                default: break;
            }
            base.WndProc(ref m);
            if (m.Msg == WM_NCHITTEST && (int)m.Result == HTCLIENT) m.Result = (IntPtr)HTCAPTION;
        }
        void Panel1_MouseDown(object sender, MouseEventArgs e)
        {
            Drag = true;
            MouseX = Cursor.Position.X - this.Left;
            MouseY = Cursor.Position.Y - this.Top;
        }
        void Panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (Drag)
            {
                this.Top = Cursor.Position.Y - MouseY;
                this.Left = Cursor.Position.X - MouseX;
            }
        }
        void Panel1_MouseUp(object sender, MouseEventArgs e) { Drag = false; }
        //---End--\\


        public Form2()
        {
            InitializeComponent();
        }

        async void PictureBox1_Click(object sender, EventArgs e)
        {
            while (Opacity != 0) //Until transparency is 0
            {
                Opacity -= 0.1; //Minus 10% transparency
                await Task.Delay(5); //5 ms delay
            }
            Window.Value = 0;
            this.Hide(); //Closing the form
        }

        async void Form2_Activated(object sender, EventArgs e)
        {
            // Language change
            if (Lang.Value == "Russian")
            {
                label2.Text = label2.Text.Replace("Developed By Net2Fox", "Разработчик - Net2Fox"); //Replace
                label3.Text = label3.Text.Replace("Cipher by ZerZru", "Шифр - ZerZru"); 
                label2.Location = new Point(34, 68); //The alignment of the text in the center
                label3.Location = new Point(69, 99); 
            }
            else if (Lang.Value == "English")
            {
                label2.Text = label2.Text.Replace("Разработчик - Net2Fox", "Developed By Net2Fox"); //Replace
                label3.Text = label3.Text.Replace("Шифр - ZerZru", "Cipher by ZerZru"); 
                label2.Location = new Point(37, 68); //The alignment of the text in the center
                label3.Location = new Point(60, 99); 
            }
            while (Opacity != 1) //Until transparency is 1
            {
                Opacity += 0.1; //Plus 10% transparency
                await Task.Delay(5); //5 ms delay
            }
        }

    }
}
