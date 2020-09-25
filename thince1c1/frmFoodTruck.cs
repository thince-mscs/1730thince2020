using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace thince1c1
{
    public partial class frmFoodTruck : Form
    {
        public frmFoodTruck()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            //  txtHotDogsSubtotal.Text = (
            //          4.00m * Convert.ToInt32(txtHotDogs.Text) 
            //          ).ToString("0.00");
            int hotDogs = Convert.ToInt32(txtHotDogs.Text);
            decimal hotDogPrice = 4.0m;
            decimal hotDogSubtotal = hotDogs * hotDogPrice;
            txtHotDogsSubtotal.Text = hotDogSubtotal.ToString("0.00");

            // txtHamburgersSubtotal.Text = ( 
            //         5.00m * Convert.ToDecimal(txtHamburgers.Text)  
            //         ).ToString("0.00");
            int Hamburgers = Convert.ToInt32(txtHamburgers.Text);
            decimal HamburgersPrice = 5.0m;
            decimal HamburgersSubtotal = Hamburgers * HamburgersPrice;
            txtHamburgersSubtotal.Text = HamburgersSubtotal.ToString("0.00");

            //txtPretaxTotal.Text = (
            //       Convert.ToDecimal(txtHotDogsSubtotal.Text) + Convert.ToDecimal(txtHamburgersSubtotal.Text) 
            //       ).ToString("0.00");
            decimal PreTaxTotal = hotDogSubtotal + HamburgersSubtotal;
            txtPretaxTotal.Text = PreTaxTotal.ToString("0.00");

            //txtTax.Text = (
            //        Convert.ToDecimal(txtPretaxTotal.Text)  * Convert.ToDecimal(0.06875) // or I can write this as 6.875m * Convert.ToDecimal(txtPretaxTotal.Text) / 100m 
            //        ).ToString("0.00");
            decimal Tax = 6.875m * PreTaxTotal / 100;
            txtTax.Text = Tax.ToString("0.00");

            //txtTotal.Text = (
            //        Convert.ToDecimal(txtPretaxTotal.Text) + Convert.ToDecimal(txtTax.Text)
            //        ).ToString("0.00");
            decimal total = PreTaxTotal + Tax;
            txtTotal.Text = total.ToString("0.00");

            btnClear.Focus();
        }

        private void frmFoodTruck_Load(object sender, EventArgs e)
        {

        }

        private void txtHamburgersSubtotal_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtHotDogs.Text = "0";
            txtHamburgers.Text = "0";
            txtHotDogsSubtotal.Text = "";
            txtHamburgersSubtotal.Text = "";
            txtPretaxTotal.Text = "";
            txtTax.Text = "";
            txtTotal.Text = "";

            txtHotDogs.Focus();
        }

        private void txtHotDogs_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
