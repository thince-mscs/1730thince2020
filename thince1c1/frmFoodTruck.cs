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
            txtHotDogsSubtotal.Text = (
                    4.0m * Convert.ToDecimal(txtHotDogs.Text)
                ).ToString("0.00");
            txtHamburgersSubtotal.Text = (
                   5.0m * Convert.ToDecimal(txtHamburgers.Text)
               ).ToString("0.00");
            txtPretaxTotal.Text = (
                Convert.ToDecimal(txtHotDogsSubtotal.Text) + Convert.ToDecimal(txtHamburgersSubtotal.Text)
             ).ToString("0.00");
            txtTax.Text =
            (Convert.ToDecimal(txtPretaxTotal.Text)
            * Convert.ToDecimal(0.06875)).ToString("0.00");
            txtTotal.Text = (Convert.ToDecimal(txtPretaxTotal.Text) + Convert.ToDecimal(txtTax.Text)).ToString("0.00");
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
    }
}
