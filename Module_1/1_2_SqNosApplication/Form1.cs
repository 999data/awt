using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SqNosApplication
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Sq_Click(object sender, EventArgs e)
        {
            int start;
            int end;
            start = Convert.ToInt32(textBox1.Text);
            end = Convert.ToInt32(textBox2.Text);

            for(int i = start; i<=end; i++)
            {
                int sq;
                sq = i * i;
                listBox1.Items.Add(i.ToString() + "\t" + sq.ToString());
            }
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            listBox1.Items.Clear();
        }

        private void Close_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
