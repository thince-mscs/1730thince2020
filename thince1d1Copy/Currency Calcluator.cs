using System;
using System.Windows.Forms;

namespace thince1d1Copy
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtAmountAustralia.Text = "0.00";
            txtRateAustralia.Text = "0.725832";
            txtAmountBhutan.Text = "0.00";
            txtRateBhutan.Text = "0.0136087";
            txtAmountKrone.Text = "0.00";
            txtRateKrone.Text = "0.11943";
            txtAmountEuro.Text = "0.00";
            txtRateEuro.Text = "1.18429";
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtAmountBhutan_TextChanged(object sender, EventArgs e)
        {
            txtUSDBhutan.Text = (Convert.ToDecimal(txtAmountBhutan.Text) * Convert.ToDecimal(txtRateBhutan.Text)).ToString("0.00");
        }

        private void txtAmountKrone_TextChanged(object sender, EventArgs e)
        {
            txtUSDKrone.Text = (Convert.ToDecimal(txtAmountKrone.Text) * Convert.ToDecimal(txtRateKrone.Text)).ToString("0.00");
        }

        private void txtAmountEuro_TextChanged(object sender, EventArgs e)
        {
            txtUSDEuro.Text = (Convert.ToDecimal(txtAmountEuro.Text) * Convert.ToDecimal(txtRateEuro.Text)).ToString("0.00");
        }

        private void txtAmountAustralia_TextChanged(object sender, EventArgs e)
        {
            txtUSDAustralia.Text = (Convert.ToDecimal(txtAmountAustralia.Text) * Convert.ToDecimal(txtRateAustralia.Text)).ToString("0.00");
        }

        private void usdTextChanged(object sender, EventArgs e)
        {
            txtTotalUSD.Text = (Convert.ToDecimal(txtUSDAustralia.Text) +
                Convert.ToDecimal(txtUSDBhutan.Text) +
                Convert.ToDecimal(txtUSDKrone.Text) +
                Convert.ToDecimal(txtUSDEuro.Text)).ToString("0.00");
        }

        private void txtRateAustralia_TextChanged(object sender, EventArgs e)
        {
            txtUSDAustralia.Text = (Convert.ToDecimal(txtAmountAustralia.Text) * Convert.ToDecimal(txtRateAustralia.Text)).ToString("0.00");
        }

        private void txtRateBhutan_TextChanged(object sender, EventArgs e)
        {
            txtUSDBhutan.Text = (Convert.ToDecimal(txtAmountBhutan.Text) * Convert.ToDecimal(txtRateBhutan.Text)).ToString("0.00");
        }

        private void txtRateKrone_TextChanged(object sender, EventArgs e)
        {
            txtUSDKrone.Text = (Convert.ToDecimal(txtAmountKrone.Text) * Convert.ToDecimal(txtRateKrone.Text)).ToString("0.00");
        }

        private void txtRateEuro_TextChanged(object sender, EventArgs e)
        {
            txtUSDEuro.Text = (Convert.ToDecimal(txtAmountEuro.Text) * Convert.ToDecimal(txtRateEuro.Text)).ToString("0.00");
        }
    }
}
