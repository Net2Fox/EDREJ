using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EDREJ_1._4
{
    public partial class Form1 : Form
    {
        //Which button is selected
        string butt;
        //Language
        string Lang = "English";
        //Registr
        RegistryKey reg = Registry.CurrentUser;
        //Input string
        string source = "";
        //Dictionary Declaration
        Dictionary<string, string> ruseng = new Dictionary<string, string>();
        Dictionary<string, string> engjap = new Dictionary<string, string>();

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
            ruseng.Add("ж", "j");
            ruseng.Add("з", "z");
            ruseng.Add("и", "i");
            ruseng.Add("й", "ii");
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
            ruseng.Add("ы", "yi");
            ruseng.Add("ь", "'");
            ruseng.Add("э", "je");
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
            engjap.Add("shi", "し");
            engjap.Add("su", "す");
            engjap.Add("se", "せ");
            engjap.Add("so", "そ");
            engjap.Add("ta", "た");
            engjap.Add("chi", "ち");
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
            engjap.Add("wa", "わ");
            engjap.Add("wo", "を");
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
                RegistryKey Language = reg.OpenSubKey("EDREJ", true);
                Lang = Convert.ToString(Language.GetValue("Language"));
            }
            catch
            {
                RegistryKey Language = reg.CreateSubKey("EDREJ");
                Language.SetValue("Language", Convert.ToString(Lang));
            }
            //Language change
            if (Lang == "Russian")
            {
                radioButton2.Checked = true;
                Enc.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
                Cln.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
                Dec.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 204);
                Cip.Text = Cip.Text.Replace("Cipher", "Шифр");
                Sett.Text = Sett.Text.Replace("Settings", "Настройки");
                Aut.Text = Aut.Text.Replace("Author", "Автор");
                Enc.Text = Enc.Text.Replace("Encrypt", "Зашифровать");
                Cln.Text = Cln.Text.Replace("Clean", "Очистить");
                Dec.Text = Dec.Text.Replace("Decrypt", "Расшифровать");
                label3.Text = label3.Text.Replace("Language", "Язык");
                label5.Text = label5.Text.Replace("Developed By Net2Fox.", "Разработчик - Net2Fox.");
                label6.Text = label6.Text.Replace("Cipher by ZerZru.", "Шифр - ZerZru.");
                radioButton1.Text = radioButton1.Text.Replace("English", "Английский");
                radioButton2.Text = radioButton2.Text.Replace("Russian", "Русский");
                radioButton1.Location = new Point(39, 26);
                radioButton2.Location = new Point(56, 49);
                label3.Location = new Point(79, 3);
                label5.Location = new Point(-2, 26);
                label6.Location = new Point(33, 53);
            }
            else if(Lang == "English")
            {
                Enc.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
                Cln.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
                Dec.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
                radioButton1.Checked = true;
                Cip.Text = Cip.Text.Replace("Шифр", "Cipher");
                Sett.Text = Sett.Text.Replace("Настройки", "Settings");
                Aut.Text = Aut.Text.Replace("Автор", "Author");
                Enc.Text = Enc.Text.Replace("Зашифровать", "Encrypt");
                Cln.Text = Cln.Text.Replace("Очистить", "Clean");
                Dec.Text = Dec.Text.Replace("Расшифровать", "Decrypt");
                label3.Text = label3.Text.Replace("Язык", "Language");
                label5.Text = label5.Text.Replace("Разработчик - Net2Fox.", "Developed By Net2Fox");
                label6.Text = label6.Text.Replace("Шифр - ZerZru.", "Cipher by ZerZru.");
                radioButton1.Text = radioButton1.Text.Replace("Английский", "English");
                radioButton2.Text = radioButton2.Text.Replace("Русский", "Russian");
                radioButton1.Location = new Point(60, 26);
                radioButton2.Location = new Point(58, 49);
                label3.Location = new Point(58, 3);
                label5.Location = new Point(3, 26);
                label6.Location = new Point(26, 53);
            }
            else
            {
                await Task.Delay(500);
                MesBox("Critical Error!", "Critical Error!");
                Application.Exit();
            }
        }

        //Press the "Cipher" button
        void Cip_Click(object sender, EventArgs e)
        {
            butt = "Cipher";
            LabMove();
            CipPan.Visible = true;
            SettPan.Visible = false;
            AuthorPan.Visible = false;
        }

        //Press the "Settings" button
        void Sett_Click(object sender, EventArgs e)
        {
            butt = "Settings";
            LabMove();
            CipPan.Visible = false;
            SettPan.Visible = true;
            AuthorPan.Visible = false;
        }

        //Press the "Author" button
        void Aut_Click(object sender, EventArgs e)
        {
            butt = "Author";
            LabMove();
            CipPan.Visible = false;
            SettPan.Visible = false;
            AuthorPan.Visible = true;
        }

        //Moving the underlining strip
        async void LabMove()
        {
            await Task.Run(() =>
            {
                if (butt == "Cipher")
                {
                    label1.Location = new Point(-2, 12);
                }
                else if (butt == "Settings")
                {
                    label1.Location = new Point(90, 12);
                }
                else if(butt == "Author")
                {
                    label1.Location = new Point(183, 12);
                }
            });
        }

        //Eng lang
        void RadioButton1_CheckedChanged(object sender, EventArgs e)
        {
            Lang = "English";
            Enc.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            Cln.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            Dec.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            Cip.Text = Cip.Text.Replace("Шифр", "Cipher");
            Sett.Text = Sett.Text.Replace("Настройки", "Settings");
            Aut.Text = Aut.Text.Replace("Автор", "Author");
            Enc.Text = Enc.Text.Replace("Зашифровать", "Encrypt");
            Cln.Text = Cln.Text.Replace("Очистить", "Clean");
            Dec.Text = Dec.Text.Replace("Расшифровать", "Decrypt");
            label3.Text = label3.Text.Replace("Язык", "Language");
            label5.Text = label5.Text.Replace("Разработчик - Net2Fox.", "Developed By Net2Fox");
            label6.Text = label6.Text.Replace("Шифр - ZerZru.", "Cipher by ZerZru.");
            radioButton1.Text = radioButton1.Text.Replace("Английский", "English");
            radioButton2.Text = radioButton2.Text.Replace("Русский", "Russian");
            radioButton1.Location = new Point(60, 26);
            radioButton2.Location = new Point(58, 49);
            label3.Location = new Point(58, 3);
            label5.Location = new Point(3, 26);
            label6.Location = new Point(26, 53);
            RegistryKey Language = reg.OpenSubKey("EDREJ", true);
            Language.SetValue("Language", Convert.ToString(Lang));
        }

        //Rus lang
        void RadioButton2_CheckedChanged(object sender, EventArgs e)
        {
            Lang = "Russian";
            Enc.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            Cln.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            Dec.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 204);
            Cip.Text = Cip.Text.Replace("Cipher", "Шифр");
            Sett.Text = Sett.Text.Replace("Settings", "Настройки");
            Aut.Text = Aut.Text.Replace("Author", "Автор");
            Enc.Text = Enc.Text.Replace("Encrypt", "Зашифровать");
            Cln.Text = Cln.Text.Replace("Clean", "Очистить");
            Dec.Text = Dec.Text.Replace("Decrypt", "Расшифровать");
            label3.Text = label3.Text.Replace("Language", "Язык");
            label5.Text = label5.Text.Replace("Developed By Net2Fox.", "Разработчик - Net2Fox.");
            label6.Text = label6.Text.Replace("Cipher by ZerZru.", "Шифр - ZerZru.");
            radioButton1.Text = radioButton1.Text.Replace("English", "Английский");
            radioButton2.Text = radioButton2.Text.Replace("Russian", "Русский");
            radioButton1.Location = new Point(39, 26);
            radioButton2.Location = new Point(56, 49);
            label3.Location = new Point(79, 3);
            label5.Location = new Point(-2, 26);
            label6.Location = new Point(33, 53);
            RegistryKey Language = reg.OpenSubKey("EDREJ", true);
            Language.SetValue("Language", Convert.ToString(Lang));
        }

        //Encrypt
        async void Enc_Click(object sender, EventArgs e)
        {
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
                    source = source.ToLower().Replace("shi", "し");
                    source = source.ToLower().Replace("su", "す");
                    source = source.ToLower().Replace("se", "せ");
                    source = source.ToLower().Replace("so", "そ");
                    source = source.ToLower().Replace("ta", "た");
                    source = source.ToLower().Replace("chi", "ち");
                    source = source.ToLower().Replace("tsu", "つ");
                    source = source.ToLower().Replace("te", "て");
                    source = source.ToLower().Replace("to", "と");
                    source = source.ToLower().Replace("na", "な");
                    source = source.ToLower().Replace("ni", "に");
                    source = source.ToLower().Replace("nu", "ぬ");
                    source = source.ToLower().Replace("ne", "ね");
                    source = source.ToLower().Replace("no", "の");
                    source = source.ToLower().Replace("ha", "は");
                    source = source.ToLower().Replace("hi", "ひ");
                    source = source.ToLower().Replace("fu", "ふ");
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
                    source = source.ToLower().Replace("wa", "わ");
                    source = source.ToLower().Replace("wo", "を");
                    source = source.ToLower().Replace(pair.Key, pair.Value);
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
                if (Lang == "Russian")
                {
                    MesBox("Введите текст!", "Ошибка");
                }
                else
                {
                    MesBox("Enter text!", "Error");
                }
            }
            Enc.Enabled = true;
        }

        //Clean
        async void Cln_Click(object sender, EventArgs e)
        {
            Cln.Enabled = false;
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
            Cln.Enabled = true;
        }

        //Decrypt
        async void Dec_Click(object sender, EventArgs e)
        {
            Dec.Enabled = false;
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
                    source = source.ToLower().Replace("ii", "й");
                    source = source.ToLower().Replace("shch", "щ");
                    source = source.ToLower().Replace("ch", "ч");
                    source = source.ToLower().Replace("sh", "ш");
                    source = source.ToLower().Replace("yj", "ъ");
                    source = source.ToLower().Replace("yi", "ы");
                    source = source.ToLower().Replace("je", "э");
                    source = source.ToLower().Replace("yu", "ю");
                    source = source.ToLower().Replace("ya", "я");
                    source = source.ToLower().Replace(pair.Value, pair.Key);
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
                if (Lang == "Russian")
                {
                    MesBox("Введите текст!", "Ошибка");
                }
                else
                {
                    MesBox("Enter text!", "Error");
                }
            }
            Dec.Enabled = true;
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
                if (Lang == "Russian")
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
    }
}
