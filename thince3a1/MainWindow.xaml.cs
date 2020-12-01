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

namespace thince3a1
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
        {
            resultTextBox0.Text = Ex3aLoops.Calc0(
                inputTextBox0a.Text, inputTextBox0b.Text, inputTextBox0c.Text);
            resultTextBox1.Text = Ex3aLoops.Calc1(
                inputTextBox1a.Text, inputTextBox1b.Text, inputTextBox1c.Text);
            resultTextBox2.Text = Ex3aLoops.Calc2(
            inputTextBox2a.Text, inputTextBox2b.Text, inputTextBox2c.Text);
        }
    }
}
