using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace testcsharp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        int cookies = 0;
        int cps = 1;
        String nec = "Not enough cookies!!";

        private async void button1_Click(object sender, EventArgs e)
        {
            cookies += cps;
            label1.Text = "Cookies: " + cookies.ToString();
            button1.Enabled = false;
            await Task.Delay(30);
            button1.Enabled = true;
        }

        private async void button2_Click(object sender, EventArgs e)
        {
            if(cookies >= 50)
            {
                cps += 1;
                cookies -= 50;
                button2.Text = "Upgrade 1: Purchased!";
                button2.Enabled = false;
            }
            else
            {
                button2.Enabled = false;
                button2.Text = nec;

                await Task.Delay(2000);
                button2.Enabled = true;
                button2.Text = "Upgrade 1: 50 Cookies";
            }
        }

        private async void Form1_Load(object sender, EventArgs e)
        {
            while(true)
            {
                await Task.Delay(1);
                label1.Text = "Cookies: " + cookies.ToString();
            }
        }

        private async void button3_Click(object sender, EventArgs e)
        {
            if (cookies >= 200)
            {
                cps += 3;
                cookies -= 200;
                button3.Text = "Upgrade 2: Purchased!";
                button3.Enabled = false;
            }
            else
            {
                button3.Enabled = false;
                button3.Text = nec;

                await Task.Delay(2000);
                button3.Enabled = true;
                button3.Text = "Upgrade 2: 200 Cookies";
            }
        }

        private async void button4_Click(object sender, EventArgs e)
        {
            if (cookies >= 1000)
            {
                cps += 1;
                cps *= 5176241; // Random number so it looks cooler
                cookies -= 1000;
                button4.Text = "Upgrade 3: Purchased!";
                button4.Enabled = false;
            }
            else
            {
                button4.Enabled = false;
                button4.Text = nec;

                await Task.Delay(2000);
                button4.Enabled = true;
                button4.Text = "Upgrade 3: 1000 Cookies";
            }
        }
    }
}
