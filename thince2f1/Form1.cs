using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace thince2f1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            decimal subtotal = 0m;
            decimal discountPercent = 0m;

            // #1 if
            //subtotal = Decimal.Parse(input1ATextbox.Text);
            //if (subtotal >= 100m)
            //   discountPercent = 0.2m;
            //result1TextBox.Text = discountPercent.ToString("n2");
            result1TextBox.Text = Ex2fCalculations.Calc01(input1ATextbox.Text);

            // #2: if {block}         
            //subtotal = Decimal.Parse(input2ATextbox.Text); 
            //discountPercent = 0m;
            //string status = "Standard rate: ";
            //if (subtotal >= 100m)
            //{
            //    discountPercent = 0.2m;
            //    status = "Bulk rate: ";
            //}
            result2TextBox.Text = Ex2fCalculations.Calc02(input2ATextbox.Text);


            // #3: if else          
            //subtotal = Decimal.Parse(input3ATextbox.Text);
            //discountPercent = 0m;
            //if (subtotal >= 100m)
            //    discountPercent = 0.2m;
            //else
            //    discountPercent = 0.1m;
            result3TextBox.Text = Ex2fCalculations.Calc03(input3ATextbox.Text);

            // #4:
            //subtotal = Decimal.Parse(input4ATextbox.Text);
            //discountPercent = 0m;
            //if (subtotal >= 100 && subtotal < 200)
            //    discountPercent = 0.2m;
            //else if (subtotal >= 200m && subtotal < 300)
            //    discountPercent = 0.3m;
            //else if (subtotal >= 300m)
            //    discountPercent = 0.4m;
            //else
            //    discountPercent = 0.1m;
            result4TextBox.Text = Ex2fCalculations.Calc04(input4ATextbox.Text);

            // #5: Better range test
            //subtotal = Decimal.Parse(input5ATextbox.Text);
            //discountPercent = 0m;
            //if (subtotal >= 300m)
            //    discountPercent = 0.4m;
            //else if (subtotal >=  200m)
            //    discountPercent = 0.3m;
            //else if (subtotal >= 100m)
            //    discountPercent = 0.2m;
            //else
            //    discountPercent = 0.1m;
            result5TextBox.Text = Ex2fCalculations.Calc05(input5ATextbox.Text);

            // #6:
            //subtotal = Decimal.Parse(input6ATextbox.Text);
            //string customerType = (input6BTextbox.Text);
            //discountPercent = 0m;
            //if (customerType == "R")
            //{
            //    if (subtotal >= 100m)
            //        discountPercent = 0.2m;
            //    else
            //        discountPercent = 0.1m;
            //}
            //else            // customerType isn't "R"
            //    discountPercent = 0.4m;
            result6TextBox.Text = Ex2fCalculations.Calc06(input6ATextbox.Text, input6BTextbox.Text);

            // #7: input validation
            result7TextBox.Text = Ex2fCalculations.Calc07(input7ATextbox.Text);


            // #8: input validation, calculate total and shopping
            // Shipping = $5.00 for orders under $50.00
            result8TextBox.Text = Ex2fCalculations.Calc08(input8ATextbox.Text, input8BTextbox.Text);

            // #9
            result9TextBox.Text = Ex2fCalculations.Calc08(input9ATextbox.Text, input9BTextbox.Text);

            // #10
            result10TextBox.Text = Ex2fCalculations.Calc08(input10ATextbox.Text, input10BTextbox.Text);

        }
    }
}
