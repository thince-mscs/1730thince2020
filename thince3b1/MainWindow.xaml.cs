using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace thince3b1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void calcButton_Click(object sender, RoutedEventArgs e) 
            // Method GetDiscountPercent pass it as a decimal (subtotal) 
            // return decimal as (discountPercent)
            // store it here in DP then display result as discountPercent.Tostring("f3");
        {
            try
            {
                decimal subtotal = Decimal.Parse(inputTextBox0a.Text);
                decimal discountPercent = Ex3bCalculations.GetDiscountPercent(subtotal);
                resultTextBox0.Text = discountPercent.ToString("f3");
            }
            catch
            {
                MessageBox.Show("Invalid input: " + this.inputTextBox0a.Text);
            }
            try
            {
                int months = Int32.Parse(this.inputTextBox2a.Text);                    // go to textbox2a parse it as an int and put it into months
                decimal monthlyInvestment = Decimal.Parse(this.inputTextBox2b.Text);   // go to textbox2b parse it and put it into monthlyInvestments
                decimal monthlyInterestRate = Decimal.Parse(this.inputTextBox2c.Text); // go to textbox2c parse it as a decimal and copy it into monthlyInterestRate
                decimal futureValue = Ex3bCalculations.CalculateFutureValue(monthlyInvestment, monthlyInterestRate, months);
                resultTextBox2.Text = futureValue.ToString("c2");
            }
            catch
            {
                MessageBox.Show("Invalid input:\n"
                    + this.inputTextBox2a.Text + "\n"
                    + this.inputTextBox2b.Text + "\n"
                    + this.inputTextBox2c.Text + "\n");
            }
        }
    }
}
