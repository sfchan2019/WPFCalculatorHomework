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
using Calculator;
using System.Text.RegularExpressions;

namespace CalculatorWPFProject
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        CalculatorUnderTest calculator;
        public MainWindow()
        {
            InitializeComponent();
            InitializeCalculatorProgram();
        }

        private void InitializeCalculatorProgram()
        {
            calculator = new CalculatorUnderTest();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            double num1 = Double.Parse(textBox1.Text);
            double num2 = Double.Parse(textBox2.Text);
            MessageBox.Show(Calculate(num1, num2).ToString());
        }

        private double Calculate(double num1, double num2)
        {
            int selection = calculation.SelectedIndex;
            switch (selection)
            {
                case 0:
                    return calculator.Add(num1, num2);
                case 1:
                    return calculator.Minus(num1, num2);
                case 2:
                    return calculator.Multiply(num1, num2);
                case 3:
                    return calculator.Divide(num1, num2);
                default:
                    throw (new Exception());
            }
        }

        private void NumberValidationTextBox(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^0-9]+.[0-9]");
            e.Handled = regex.IsMatch(e.Text);
        }
    }
}
