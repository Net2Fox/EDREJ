using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EDREJ_1._5
{
    public partial class Form1 : Form
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
        private void Panel1_MouseDown(object sender, MouseEventArgs e)
        {
            Drag = true;
            MouseX = Cursor.Position.X - this.Left;
            MouseY = Cursor.Position.Y - this.Top;
        }
        private void Panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (Drag)
            {
                this.Top = Cursor.Position.Y - MouseY;
                this.Left = Cursor.Position.X - MouseX;
            }
        }
        private void Panel1_MouseUp(object sender, MouseEventArgs e) { Drag = false; }
        //---End--\\


        //Input string
        string source = "";
        //Dictionary Declaration
        Dictionary<string, string> ruseng = new Dictionary<string, string>();
        Dictionary<string, string> engjap = new Dictionary<string, string>();
        Form2 about = new Form2(); //Form "About"

        public Form1()
        {
            InitializeComponent();
            //Russian letters in English characters
            ruseng.Add("а", "a");
            ruseng.Add("б", "b");
            ruseng.Add("в", "v");
            ruseng.Add("г", "g");
            ruseng.Add("д", "d");
            ruseng.Add("е", "e");
            ruseng.Add("ё", "yo");
            ruseng.Add("ж", "zh");
            ruseng.Add("з", "z");
            ruseng.Add("и", "i");
            ruseng.Add("й", "i");
            ruseng.Add("к", "k");
            ruseng.Add("л", "l");
            ruseng.Add("м", "m");
            ruseng.Add("н", "n");
            ruseng.Add("о", "o");
            ruseng.Add("п", "p");
            ruseng.Add("р", "r");
            ruseng.Add("с", "s");
            ruseng.Add("т", "t");
            ruseng.Add("у", "u");
            ruseng.Add("ф", "f");
            ruseng.Add("х", "h");
            ruseng.Add("ц", "c");
            ruseng.Add("ч", "ch");
            ruseng.Add("ш", "sh");
            ruseng.Add("щ", "shch");
            ruseng.Add("ъ", "yj");
            ruseng.Add("ы", "i");
            ruseng.Add("ь", "'");
            ruseng.Add("э", "e");
            ruseng.Add("ю", "yu");
            ruseng.Add("я", "ya");

            //Japanese characters
            engjap.Add("a", "あ");
            engjap.Add("i", "い");
            engjap.Add("u", "う");
            engjap.Add("e", "え");
            engjap.Add("o", "お");
            engjap.Add("ka", "か");
            engjap.Add("ki", "き");
            engjap.Add("ku", "く");
            engjap.Add("ke", "け");
            engjap.Add("ko", "こ");
            engjap.Add("sa", "さ");
            engjap.Add("si", "し");
            engjap.Add("su", "す");
            engjap.Add("se", "せ");
            engjap.Add("so", "そ");
            engjap.Add("ta", "た");
            engjap.Add("ti", "ち");
            engjap.Add("tsu", "つ");
            engjap.Add("te", "て");
            engjap.Add("to", "と");
            engjap.Add("na", "な");
            engjap.Add("ni", "に ");
            engjap.Add("nu", "ぬ");
            engjap.Add("ne", "ね");
            engjap.Add("no", "の");
            engjap.Add("fu", "ふ");
            engjap.Add("ha", "は");
            engjap.Add("hi", "ひ");
            engjap.Add("he", "へ");
            engjap.Add("ho", "ほ");
            engjap.Add("ma", "ま");
            engjap.Add("mi", "み");
            engjap.Add("mu", "む");
            engjap.Add("me", "め");
            engjap.Add("mo", "も");
            engjap.Add("ya", "や");
            engjap.Add("yu", "ゆ");
            engjap.Add("yo", "よ");
            engjap.Add("ra", "ら");
            engjap.Add("ri", "り");
            engjap.Add("ru", "る");
            engjap.Add("re", "れ");
            engjap.Add("ro", "ろ");
            engjap.Add("va", "わ");
            engjap.Add("vo", "を");
            engjap.Add("n", "ん");

            engjap.Add("ga", "が");
            engjap.Add("gi", "ぎ");
            engjap.Add("gu", "ぐ");
            engjap.Add("ge", "げ");
            engjap.Add("go", "ご");
            engjap.Add("za", "ざ");
            engjap.Add("zi", "じ");
            engjap.Add("zu", "ず");
            engjap.Add("ze", "ぜ");
            engjap.Add("zo", "ぞ");
            engjap.Add("da", "だ");
            engjap.Add("di", "ぢ");
            engjap.Add("du", "づ");
            engjap.Add("de", "で");
            engjap.Add("do", "ど");
            engjap.Add("ba", "ば");
            engjap.Add("bi", "び ");
            engjap.Add("bu", "ぶ");
            engjap.Add("be", "べ");
            engjap.Add("bo", "ぼ");
            engjap.Add("pa", "ぱ");
            engjap.Add("pi", "ぴ");
            engjap.Add("pu", "ぷ");
            engjap.Add("pe", "ぺ");
            engjap.Add("po", "ぽ");
        }

        //Load events
        async void Form1_Load(object sender, EventArgs e)
        {
            //Trying to read registry data
            try
            {
                RegistryKey Language = RegistyK.reg.OpenSubKey("EDREJ", true);
                Lang.Value = Convert.ToString(Language.GetValue("Language"));
            }
            catch
            {
                Lang.Value = "English";
                RegistryKey Language = RegistyK.reg.CreateSubKey("EDREJ");
                Language.SetValue("Language", Convert.ToString(Lang.Value));
            }
            //Language change
            if (Lang.Value == "Russian")
            {
                Enc.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204); //Change font
                Cln.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
                Dec.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 204);
                Enc.Text = Enc.Text.Replace("Encrypt", "Зашифровать"); //Replace
                Cln.Text = Cln.Text.Replace("Clean", "Очистить");
                Dec.Text = Dec.Text.Replace("Decrypt", "Расшифровать");
            }
            else if(Lang.Value == "English")
            {
                Enc.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204); //Change font
                Cln.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
                Dec.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
                Enc.Text = Enc.Text.Replace("Зашифровать", "Encrypt"); //Replace
                Cln.Text = Cln.Text.Replace("Очистить", "Clean");
                Dec.Text = Dec.Text.Replace("Расшифровать", "Decrypt");
            }
            else
            {
                await Task.Delay(500);
                MesBox("Critical Error!", "Critical Error!");
                Application.Exit();
            }

            while (Opacity != 1) //Until transparency is 1
            {
                Opacity += 0.1; //Plus 10% transparency
                await Task.Delay(5); //5 ms delay
            }
        }

        //Eng lang
        void RadioButton1_CheckedChanged(object sender, EventArgs e)
        {
            Lang.Value = "English";
            Enc.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204); //Change font
            Cln.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            Dec.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            Enc.Text = Enc.Text.Replace("Зашифровать", "Encrypt"); //Replace
            Cln.Text = Cln.Text.Replace("Очистить", "Clean");
            Dec.Text = Dec.Text.Replace("Расшифровать", "Decrypt");
            RegistryKey Language = RegistyK.reg.OpenSubKey("EDREJ", true);
            Language.SetValue("Language", Convert.ToString(Lang.Value));
        }

        //Rus lang
        void RadioButton2_CheckedChanged(object sender, EventArgs e)
        {
            Lang.Value = "Russian";
            Enc.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204); //Change font
            Cln.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            Dec.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 204);
            Enc.Text = Enc.Text.Replace("Encrypt", "Зашифровать"); //Replace
            Cln.Text = Cln.Text.Replace("Clean", "Очистить");
            Dec.Text = Dec.Text.Replace("Decrypt", "Расшифровать");
            RegistryKey Language = RegistyK.reg.OpenSubKey("EDREJ", true);
            Language.SetValue("Language", Convert.ToString(Lang.Value));
        }

        //Encrypt
        async void Enc_Click(object sender, EventArgs e)
        {
            Dec.Enabled = false;
            Cln.Enabled = false;
            Enc.Enabled = false;
            try
            {
                //The clearing of a field of the message
                label2.Text = "";
                source = textBox1.Text;
                //Replace characters
                foreach (KeyValuePair<string, string> pair in ruseng)
                {
                    source = source.ToLower().Replace(pair.Key, pair.Value);
                }
                foreach (KeyValuePair<string, string> pair in engjap)
                {
                    source = source.ToLower().Replace("ka", "か");
                    source = source.ToLower().Replace("ki", "き");
                    source = source.ToLower().Replace("ku", "く");
                    source = source.ToLower().Replace("ke", "け");
                    source = source.ToLower().Replace("ko", "こ");
                    source = source.ToLower().Replace("sa", "さ");
                    source = source.ToLower().Replace("si", "し");
                    source = source.ToLower().Replace("su", "す");
                    source = source.ToLower().Replace("se", "せ");
                    source = source.ToLower().Replace("so", "そ");
                    source = source.ToLower().Replace("ta", "た");
                    source = source.ToLower().Replace("ti", "ち");
                    source = source.ToLower().Replace("tsu", "つ");
                    source = source.ToLower().Replace("te", "て");
                    source = source.ToLower().Replace("to", "と");
                    source = source.ToLower().Replace("na", "な");
                    source = source.ToLower().Replace("ni", "に ");
                    source = source.ToLower().Replace("nu", "ぬ");
                    source = source.ToLower().Replace("ne", "ね");
                    source = source.ToLower().Replace("no", "の");
                    source = source.ToLower().Replace("fu", "ふ");
                    source = source.ToLower().Replace("ha", "は");
                    source = source.ToLower().Replace("hi", "ひ");
                    source = source.ToLower().Replace("he", "へ");
                    source = source.ToLower().Replace("ho", "ほ");
                    source = source.ToLower().Replace("ma", "ま");
                    source = source.ToLower().Replace("mi", "み");
                    source = source.ToLower().Replace("mu", "む");
                    source = source.ToLower().Replace("me", "め");
                    source = source.ToLower().Replace("mo", "も");
                    source = source.ToLower().Replace("ya", "や");
                    source = source.ToLower().Replace("yu", "ゆ");
                    source = source.ToLower().Replace("yo", "よ");
                    source = source.ToLower().Replace("ra", "ら");
                    source = source.ToLower().Replace("ri", "り");
                    source = source.ToLower().Replace("ru", "る");
                    source = source.ToLower().Replace("re", "れ");
                    source = source.ToLower().Replace("ro", "ろ");
                    source = source.ToLower().Replace("va", "わ");
                    source = source.ToLower().Replace("vo", "を");
                    source = source.ToLower().Replace("ga", "が");
                    source = source.ToLower().Replace("gi", "ぎ");
                    source = source.ToLower().Replace("gu", "ぐ");
                    source = source.ToLower().Replace("ge", "げ");
                    source = source.ToLower().Replace("go", "ご");
                    source = source.ToLower().Replace("za", "ざ");
                    source = source.ToLower().Replace("zi", "じ");
                    source = source.ToLower().Replace("zu", "ず");
                    source = source.ToLower().Replace("ze", "ぜ");
                    source = source.ToLower().Replace("zo", "ぞ");
                    source = source.ToLower().Replace("da", "だ");
                    source = source.ToLower().Replace("di", "ぢ");
                    source = source.ToLower().Replace("du", "づ");
                    source = source.ToLower().Replace("de", "で");
                    source = source.ToLower().Replace("do", "ど");
                    source = source.ToLower().Replace("ba", "ば");
                    source = source.ToLower().Replace("bi", "び ");
                    source = source.ToLower().Replace("bu", "ぶ");
                    source = source.ToLower().Replace("be", "べ");
                    source = source.ToLower().Replace("bo", "ぼ");
                    source = source.ToLower().Replace("pa", "ぱ");
                    source = source.ToLower().Replace("pi", "ぴ");
                    source = source.ToLower().Replace("pu", "ぷ");
                    source = source.ToLower().Replace("pe", "ぺ");
                    source = source.ToLower().Replace("po", "ぽ"); 
                    source = source.ToLower().Replace(pair.Key, pair.Value);
                }
                foreach (char c in source) //All Exception
                {
                    source = source.ToLower().Replace("ぎthうb", "GitHub");
                }
                //First capital letter
                source = source.Substring(0, 1).ToUpper() + source.Remove(0, 1);
                //The effect of typesetting the text
                char[] tebox = source.ToCharArray();
                foreach (char ch in tebox)
                {
                    label2.Text += ch.ToString();
                    await Task.Delay(50);
                }
                //Clear the clipboard and enter
                Clipboard.SetDataObject(source);
            }
            catch
            {
                //Error
                if (Lang.Value == "Russian")
                {
                    MesBox("Введите текст!", "Ошибка");
                }
                else
                {
                    MesBox("Enter text!", "Error");
                }
            }
            Enc.Enabled = true;
            Dec.Enabled = true;
            Cln.Enabled = true;
        }

        //Clean
        async void Cln_Click(object sender, EventArgs e)
        {
            Cln.Enabled = false;
            Dec.Enabled = false;
            Enc.Enabled = false;
            //Clearing only the textbox
            if (label2.Text == "")
            {
                CleanTexBox();
            }
            //Clear text only
            else if (textBox1.Text == "")
            {
                //Text erase effect
                char[] tebox = source.ToCharArray();
                for (int i = tebox.Length - 1; i <= tebox.Length & i != 0; i--)
                {
                    tebox[i] = ' ';
                    string txt = new string(tebox);
                    label2.Text = "";
                    label2.Text = txt;
                    await Task.Delay(5);
                }
                source = "";
                label2.Text = "";
            }
            //Clean all
            else
            {
                //Text erase effect
                char[] tebox = source.ToCharArray();
                CleanTexBox();
                for (int i = tebox.Length - 1; i <= tebox.Length & i != 0; i--)
                {
                    tebox[i] = ' ';
                    string txt = new string(tebox);
                    label2.Text = "";
                    label2.Text = txt;
                    await Task.Delay(5);
                }
                source = "";
                label2.Text = "";
            }
            Enc.Enabled = true;
            Dec.Enabled = true;
            Cln.Enabled = true;
        }

        //Decrypt
        async void Dec_Click(object sender, EventArgs e)
        {
            Dec.Enabled = false;
            Cln.Enabled = false;
            Enc.Enabled = false;
            try
            {
                //The clearing of a field of the message
                label2.Text = "";
                source = textBox1.Text;
                //Replace characters
                foreach (KeyValuePair<string, string> pair in engjap)
                {
                    source = source.ToLower().Replace(pair.Value, pair.Key);
                }
                foreach (KeyValuePair<string, string> pair in ruseng)
                {
                    source = source.ToLower().Replace("yo", "ё");
                    source = source.ToLower().Replace("ii", "ий");
                    source = source.ToLower().Replace("shch", "щ");
                    source = source.ToLower().Replace("ch", "ч");
                    source = source.ToLower().Replace("sh", "ш");
                    source = source.ToLower().Replace("yj", "ъ");
                    source = source.ToLower().Replace("yi", "ы");
                    //???source = source.ToLower().Replace("je", "э");
                    source = source.ToLower().Replace("yu", "ю");
                    source = source.ToLower().Replace("ya", "я");
                    source = source.ToLower().Replace(pair.Value, pair.Key);
                }
                foreach (char c in source) //All Exception
                {
                    source = source.ToLower().Replace("етот", "этот");
                    source = source.ToLower().Replace("гитхуб", "GitHub");
                    source = source.ToLower().Replace("ви", "вы");
                    source = source.ToLower().Replace("выжу", "вижу");
                    source = source.ToLower().Replace("смисл", "смысл");
                }
                //First capital letter
                source = source.Substring(0, 1).ToUpper() + source.Remove(0, 1);
                //The effect of typesetting the text
                char[] tebox = source.ToCharArray();
                foreach (char ch in tebox)
                {
                    label2.Text += ch.ToString();
                    await Task.Delay(50);
                }
                //Clear the clipboard and enter
                Clipboard.SetDataObject(source);
            }
            catch
            {
                //Error
                if (Lang.Value == "Russian")
                {
                    MesBox("Введите текст!", "Ошибка");
                }
                else
                {
                    MesBox("Enter text!", "Error");
                }
            }
            Enc.Enabled = true;
            Dec.Enabled = true;
            Cln.Enabled = true;
        }


        //Clean Text Box
        async void CleanTexBox()
        {
            try
            {
                await Task.Run(async () =>
                {
                    //Text erase effect
                    char[] tebox = textBox1.Text.ToCharArray();
                    for (int i = tebox.Length - 1; i <= tebox.Length & i != 0; i--)
                    {
                        tebox[i] = ' ';
                        string txt = new string(tebox);
                        textBox1.Text = "";
                        textBox1.Text = txt;
                        await Task.Delay(5);
                    }
                    textBox1.Text = "";
                });
            }
            catch
            {
                //Error
                if (Lang.Value == "Russian")
                {
                    MesBox("Перед тем как стирать текст, Вы должны его ввести!", "Ошибка");
                }
                else
                {
                    MesBox("Before you erase the text, You must enter it!", "Error");
                }
            }
        }

        //Error Message Box
        void MesBox(string text, string header)
        {
            MessageBox.Show(text, header, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        //Closing the app
        async void PictureBox1_Click(object sender, EventArgs e)
        {
            if (about.Opacity != 0)
            {
                while (about.Opacity != 0) //ntil transparency is 0
                {
                    about.Opacity -= 0.1; //Minus 10% transparency
                    await Task.Delay(5); //5 ms delay
                }
            }
            while (Opacity != 0) //Until transparency is 0
            {
                Opacity -= 0.1; //Minus 10% transparency
                await Task.Delay(5); //5 ms delay
            }
            Application.Exit(); //Closing the app
        }

        //Pressing the about button
        void PictureBox2_Click(object sender, EventArgs e)
        {
            if(Window.Value == 1) { }
            else
            {
                about.Show(); //Show form "About"
                Window.Value = 1;
            }
        }

        //Pressing the settings button
        void PictureBox3_Click(object sender, EventArgs e)
        {
            if (Window.Value == 1) { }
            else
            {
                Form3 settings = new Form3(this); //Form "Settings"
                settings.Show(); //Show form "Settings"
                Window.Value = 1;
            }
        }
    }
}
