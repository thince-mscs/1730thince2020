using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace thince1h1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            textBoxTwo.ReadOnly = true;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void pictureBoxTwo_Click(object sender, EventArgs e)
        {
       
        }

        private void labelOne_Click(object sender, EventArgs e)
        {
            labelOne.Text = textBoxTwo.Text;
        }

        private void button2_Click(object sender, EventArgs e)
        {
           
        }

        private void labelTwo_Click(object sender, EventArgs e)
        {
            labelTwo.Text = (Convert.ToInt32("12") + 6).ToString();
        }

        private void buttonOne_Click(object sender, EventArgs e)
        {
            buttonOne.TabIndex = 5;
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {
            groupBoxTwo.Text = "5";
        }
    }
}
