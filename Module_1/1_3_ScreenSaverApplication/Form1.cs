using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ScreenSaverApplication
{
    public partial class Form1 : Form
    {
        string[] s = new string[4];
        int i = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void Start_Click(object sender, EventArgs e)
        {
            Tick.Enabled = true;
            s[0] = @"D:\awtprojects\ScreenSaverApplication\images\dog.jpg";
            s[1] = @"D:\awtprojects\ScreenSaverApplication\images\fox.jpg";
            s[2] = @"D:\awtprojects\ScreenSaverApplication\images\squirrel.jpg";
            s[3] = @"D:\awtprojects\ScreenSaverApplication\images\tiger.jpg";
        }

        private void Stop_Click(object sender, EventArgs e)
        {
            Tick.Enabled = false;
        }

        private void Tick_Tick(object sender, EventArgs e)
        {
            pictureBox1.Image = System.Drawing.Image.FromFile(s[i]);
            i++;
            if (i == 4)
            {
                i = 0;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}

