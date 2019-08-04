using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EDREJ_1._4
{
    public partial class Form1 : Form
    {
        string butt;

        public Form1()
        {
            InitializeComponent();
        }

        async void Form1_Load(object sender, EventArgs e)
        {
            for(int y = CipPan.Location.Y; y > -2; y -= 10, await Task.Delay(1))
            {
                CipPan.Location = new Point(-1, y);
            }
            CipPan.Location = new Point(-1, -2);
        }

        async void Cip_Click(object sender, EventArgs e)
        {
            butt = "Cipher";
            LabAnim();
            Cip.Enabled = false;
            for (int x = CipPan.Location.X; x < -1; x += 30, await Task.Delay(1))
            {
                CipPan.Location = new Point(x, -2);
            }
            CipPan.Location = new Point(-1, -2);
            Cip.Enabled = true;
        }

        async void Sett_Click(object sender, EventArgs e)
        {
            if(butt == "Author")
            {
                butt = "Settings1";
            }
            else
            {
                butt = "Settings";
            }
            LabAnim();
            Sett.Enabled = false;
            for (int x = CipPan.Location.X; x > -650; x -= 30, await Task.Delay(1))
            {
                CipPan.Location = new Point(x, -2);
            }
            CipPan.Location = new Point(-650, -2);
            Sett.Enabled = true;
        }

        async void Aut_Click(object sender, EventArgs e)
        {
            butt = "Author";
            LabAnim();
        }

        async void LabAnim()
        {
            await Task.Run(async () =>
            {
                if (butt == "Cipher")
                {
                    for (int x = label1.Location.X; x > -2; x -= 10, await Task.Delay(10))
                    {
                        label1.Location = new Point(x, 12);
                    }
                    label1.Location = new Point(-2, 12);
                }
                else if (butt == "Settings")
                {
                    for (int x = label1.Location.X; x < 90; x += 10, await Task.Delay(10))
                    {
                        label1.Location = new Point(x, 12);
                    }
                    label1.Location = new Point(90, 12);
                }
                else if(butt == "Settings1")
                {
                    for (int x = label1.Location.X; x > 90; x -= 10, await Task.Delay(10))
                    {
                        label1.Location = new Point(x, 12);
                    }
                    label1.Location = new Point(90, 12);
                }
                else if(butt == "Author")
                {
                    for (int x = label1.Location.X; x < 183; x += 10, await Task.Delay(10))
                    {
                        label1.Location = new Point(x, 12);
                    }
                    label1.Location = new Point(183, 12);
                }
            });
        }


    }
}
