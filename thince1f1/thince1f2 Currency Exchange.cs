using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace thince1f1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtCurrency.Select();
            btnAustralia.BackgroundImage = picAustralia.Image;
            btnBhutan.BackgroundImage = picBhutanDim.Image;
            btnKrone.BackgroundImage = picKroneDim.Image;
            btnEuro.BackgroundImage = picEuroDim.Image;
            txtRate.Text = "0.725832";
            lblCurrency.Text = btnAustralia.Text + ": ";
            txtUSDollars.Text = "0.00";
            txtTotalUSD.Text = "0.00";
        }

        private void btnAustralia_Click(object sender, EventArgs e)
        {
            btnAustralia.BackgroundImage = picAustralia.Image;
            btnBhutan.BackgroundImage = picBhutanDim.Image;
            btnKrone.BackgroundImage = picKroneDim.Image;
            btnEuro.BackgroundImage = picEuroDim.Image;
            lblCurrency.Text = btnAustralia.Text + ": ";
            txtRate.Text = "0.725832";
            txtCurrency.Focus();
        }

        private void btnBhutan_Click(object sender, EventArgs e)
        {
            btnBhutan.BackgroundImage = picBhutan.Image;
            btnKrone.BackgroundImage = picKroneDim.Image;
            btnEuro.BackgroundImage = picEuroDim.Image;
            btnAustralia.BackgroundImage = picAustraliaDim.Image;
            lblCurrency.Text = btnBhutan.Text + ": ";
            txtRate.Text = "0.0136087";
            txtCurrency.Focus();
        }

        private void btnKrone_Click(object sender, EventArgs e)
        {
            btnKrone.BackgroundImage = picKrone.Image;
            btnAustralia.BackgroundImage = picAustraliaDim.Image;
            btnBhutan.BackgroundImage = picBhutanDim.Image;
            btnEuro.BackgroundImage = picEuroDim.Image;
            lblCurrency.Text = btnKrone.Text + ": ";
            txtRate.Text = "0.11943";
            txtCurrency.Focus();
        }

        private void btnEuro_Click(object sender, EventArgs e)
        {
            btnEuro.BackgroundImage = picEuro.Image;
            btnAustralia.BackgroundImage = picAustraliaDim.Image;
            btnBhutan.BackgroundImage = picBhutanDim.Image;
            btnKrone.BackgroundImage = picKroneDim.Image;
            lblCurrency.Text = btnEuro.Text + ": ";
            txtRate.Text = "1.18429";
            txtCurrency.Focus();
        }

        private void calcUSD(object sender, EventArgs e)
        {
            txtUSDollars.Text = (Convert.ToDecimal(txtRate.Text)
                 * Convert.ToDecimal(txtCurrency.Text)).ToString("0.00");
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            lblEquation.Text = lblEquation.Text + " + " + txtUSDollars.Text;
            txtTotalUSD.Text = (Convert.ToDecimal(txtTotalUSD.Text) + Convert.ToDecimal(txtUSDollars.Text)).ToString("0.00");
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtCurrency.Text = "0.00";
            txtUSDollars.Text = "0.00";
            txtTotalUSD.Text = "0.00";
            lblEquation.Text = "";
            txtCurrency.Focus();
            btnAustralia.PerformClick();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
