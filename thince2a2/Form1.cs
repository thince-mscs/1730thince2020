using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace thince2a2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            //txtDiscountAmount.Text =
            //     (Convert.ToDecimal(txtSubtotal.Text)
            //     * Convert.ToDecimal(txtDiscountPercent.Text) / 100).ToString("0.00");

            int DiscountPercent = Convert.ToInt32(txtDiscountPercent.Text);
            decimal DiscountPercent = 5.0m;
            decimal DiscountAmount = DiscountPercent * txtSubtotal / 100;
            txtDiscountAmount.Text = DiscountAmount.ToString("0.00");

            //txtTotal.Text =
            //     (Convert.ToDecimal(txtSubtotal.Text)
            //     - Convert.ToDecimal(txtDiscountAmount.Text)).ToString("0.00");
            decimal total = txtSubtotal - txtDiscountAmount;
            txtTotal.Text = total.ToString("0.00");
            
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtDiscountAmount_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
