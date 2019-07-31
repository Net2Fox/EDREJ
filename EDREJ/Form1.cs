using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EDREJ
{
    public partial class Form1 : Form
    {
        string source = "";
        int clicks = 0;
        Dictionary<string, string> ruseng = new Dictionary<string, string>();
        Dictionary<string, string> engjap = new Dictionary<string, string>();

        public Form1()
        {
            InitializeComponent();
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
        }

        async void Form1_Load(object sender, EventArgs e)
        {
            char[] weltext = "Welcome to EDREJ!".ToCharArray();

            foreach (char ch in weltext)
            {
                label1.Text += ch.ToString();
                await Task.Delay(50);
            }
        }

        async void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                label2.Text = "";
                source = textBox1.Text;
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
                source = source.Substring(0, 1).ToUpper() + source.Remove(0, 1);
                char[] tebox = source.ToCharArray();
                foreach (char ch in tebox)
                {
                    label2.Text += ch.ToString();
                    await Task.Delay(50);
                }
                Clipboard.Clear();
                Clipboard.SetText(source);
            }
            catch
            {
                MessageBox.Show("Enter text!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void Label1_Click(object sender, EventArgs e)
        {
            clicks++;
            if(clicks == 3)
            {
                MessageBox.Show("EDREJ 1.1. \nDeveloper Net2Fox. \nCipher by ZerZru.", "Автор", MessageBoxButtons.OK, MessageBoxIcon.Information);
                clicks = 0;
            }
        }

        async void Button2_Click(object sender, EventArgs e)
        {
            try
            {
                label2.Text = "";
                source = textBox1.Text;
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
                source = source.Substring(0, 1).ToUpper() + source.Remove(0, 1);
                char[] tebox = source.ToCharArray();
                foreach (char ch in tebox)
                {
                    label2.Text += ch.ToString();
                    await Task.Delay(50);
                }
                Clipboard.Clear();
                Clipboard.SetText(source);
            }
            catch
            {
                MessageBox.Show("Enter text!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        async void Button3_Click(object sender, EventArgs e)
        {
            if (label2.Text == "")
            {
                CleanTexBox();
            }
            else if(textBox1.Text == "")
            {
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
            else 
            {
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
        }

        async void CleanTexBox()
        {
            try
            {
                await Task.Run(async () =>
                {
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
                MessageBox.Show("Before you erase the text, you must enter it!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
