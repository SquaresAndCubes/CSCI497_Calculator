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

namespace CSCI497_Calculator2
{
    //Brent Testing .gitignore
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    /// 

    public class Calculator
        {
        long number1 = 0;
        long number2 = 0;
        double results = 0;
        public String operation {get; set;} = "";
        public void NumEntry(long num_in)
            {
            if (operation != "")
                {
                number2 = num_in;
                }
            else
                {
                number1 = num_in;
                }
            }
        public String Calculate()
            {
            switch (operation)
            {
                case "+":
                    results = number1 + number2;
                    break;
                case "-":
                    results = number1 - number2;
                    break;
                case "*":
                    results = number1 * number2;
                    break;
                case "/":
                    results = number1 / number2;
                    break;

                    
            }//end switch
            return results.ToString();
            }
        }
    public partial class MainWindow : Window
    {
        Calculator thisCalculator = new Calculator();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Btn0_Click(object sender, RoutedEventArgs e)
        {
            thisCalculator.NumEntry(0);
        }

        private void Btn1_Click(object sender, RoutedEventArgs e)
        {
            thisCalculator.NumEntry(1);
        }

        private void Btn2_Click(object sender, RoutedEventArgs e)
        {
            thisCalculator.NumEntry(2);
        }

        private void Btn3_Click(object sender, RoutedEventArgs e)
        {
            thisCalculator.NumEntry(3);
        }

        private void Btn4_Click(object sender, RoutedEventArgs e)
        {
            thisCalculator.NumEntry(4);
        }

        private void Btn5_Click(object sender, RoutedEventArgs e)
        {
            thisCalculator.NumEntry(5);
        }

        private void Btn6_Click(object sender, RoutedEventArgs e)
        {
            thisCalculator.NumEntry(6);
        }

        private void Btn7_Click(object sender, RoutedEventArgs e)
        {
            thisCalculator.NumEntry(7);
        }

        private void Btn8_Click(object sender, RoutedEventArgs e)
        {
            thisCalculator.NumEntry(8);
        }

        private void Btn9_Click(object sender, RoutedEventArgs e)
        {
            thisCalculator.NumEntry(9);
        }

        private void BtnPlus_Click(object sender, RoutedEventArgs e)
        {
            thisCalculator.operation = "+";
        }

        private void BtnMinus_Click(object sender, RoutedEventArgs e)
        {
            thisCalculator.operation = "-";
        }

        private void BtnTimes_Click(object sender, RoutedEventArgs e)
        {
            thisCalculator.operation = "*";
        }

        private void BtnDivide_Click(object sender, RoutedEventArgs e)
        {
            thisCalculator.operation = "/";
        }

        private void BtnEquils_Click(object sender, RoutedEventArgs e)
        {
            
            txtAnswers.Text = thisCalculator.Calculate();
            
        }

        private void btnC_Click(object sender, RoutedEventArgs e)
        {

        }

        private void BtnPostiveNegative_Click(object sender, RoutedEventArgs e)
        {

        }

        private void BtnBack_Click(object sender, RoutedEventArgs e)
        {


        }

        private void btnCE_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
