using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace thince2d2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void setPassValuesButton_Click(object sender, EventArgs e)
        {
            textBox1Input.Text = "Frank";
            textBox2Input.Text = "";
            textBox3Input.Text = "2.3";
            textBox4Input.Text = "false";
            textBox5InputA.Text = "2";
            textBox5InputB.Text = "2";
            textBox6Input.Text = "xyz";
            textBox7Input.Text = "1";
            textBox8InputA.Text = "1";
            textBox8InputB.Text = "2";
            textBox9Input.Text = "500";
            textBox10InputA.Text = "2";
            textBox10InputB.Text = "3";


        }

        private void SetFailValuesButton_Click(object sender, EventArgs e)
        {
            textBox1Input.Text = "xyz";
            textBox2Input.Text = "xyz";
            textBox3Input.Text = "2.4";
            textBox4Input.Text = "true";
            textBox5InputA.Text = "2";
            textBox5InputB.Text = "3";
            textBox6Input.Text = "Jones";
            textBox7Input.Text = "0";
            textBox8InputA.Text = "1";
            textBox8InputB.Text = "1";
            textBox9Input.Text = "499";
            textBox10InputA.Text = "4";
            textBox10InputB.Text = "3";

        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            textBox1ResultA.Text = "Fail";
            textBox2ResultA.Text = "Fail";
            textBox3ResultA.Text = "Fail";
            textBox4ResultA.Text = "Fail";
            textBox5ResultA.Text = "Fail";
            textBox6ResultA.Text = "Fail";
            textBox7ResultA.Text = "Fail";
            textBox8ResultA.Text = "Fail";
            textBox9ResultA.Text = "Fail";
            textBox10ResultA.Text = "Fail";

            if (textBox1Input.Text == "Frank")
                textBox1ResultA.Text = "Success";

            if (textBox2Input.Text == "")
                textBox2ResultA.Text = "Success";

            //   if (textBox3Input.Text == "2.3")
            //       textBox3ResultA.Text = "Success";
            decimal val3 = Convert.ToDecimal(textBox3Input.Text);
            if (val3 == 2.3m)
                textBox3ResultA.Text = "Success";

            //   if (textBox4Input.Text == "false")
            //       textBox4ResultA.Text = "Success";
            bool val4 = Convert.ToBoolean(textBox4Input.Text);
            if (val4 == false)
                textBox4ResultA.Text = "Success";

         
            decimal val5 = Convert.ToDecimal(textBox5InputA.Text);
            if (val5 == 3m)
                textBox5ResultA.Text = "Fail";
            if (val5 == 2m)
                textBox5ResultA.Text = "Success";



                if (textBox6Input.Text == "xyz")
                textBox6ResultA.Text = "Success";

            if (textBox7Input.Text == "1")
                textBox7ResultA.Text = "Success";

            if (textBox8InputA.Text == "1")
                textBox8ResultA.Text = "Success";
            decimal val8 = Convert.ToDecimal(textBox8InputB.Text);
            if (val8 == 1m)
                textBox8ResultA.Text = "Fail";

            if (textBox9Input.Text == "500")
                textBox9ResultA.Text = "Success";

           if (textBox10InputA.Text == "2")
              textBox10ResultA.Text = "Success";
            if (textBox10InputA.Text == "4")
                textBox10ResultA.Text = "Fail";

            decimal val10 = Convert.ToDecimal(textBox10InputB.Text);
            if (val10 == 3m)
                textBox10ResultA.Text = "Success";

          //  decimal val10 = Convert.ToDecimal(textBox10InputA.Text);
         //   if (val10 != 3m)
         //      textBox10ResultA.Text = "Fail";


        }
    }
}
