﻿using System;
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
    public partial class MainWindow : Window
    {
        long number1 = 0;
        long number2 = 0;
        double Results = 0;
        String Operation = "";
        bool IsOperation = false;
        bool AfterEquals = false;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Btn0_Click(object sender, RoutedEventArgs e)
        {
            if((txtAnswers.Text == "0")||(IsOperation))
            {
                txtAnswers.Clear();
            }
            IsOperation = false;

            if (!AfterEquals)
                txtAnswers.Text = txtAnswers.Text + "0";
        }

        private void Btn1_Click(object sender, RoutedEventArgs e)
        {
            if ((txtAnswers.Text == "0") || (IsOperation))
            {
                txtAnswers.Clear();
            }
            IsOperation = false;

            if (!AfterEquals)
                txtAnswers.Text = txtAnswers.Text + "1";
        }

        private void Btn2_Click(object sender, RoutedEventArgs e)
        {
            if ((txtAnswers.Text == "0") || (IsOperation))
            {
                txtAnswers.Clear();
            }
            IsOperation = false;

            if (!AfterEquals)
                txtAnswers.Text = txtAnswers.Text + "2";
        }

        private void Btn3_Click(object sender, RoutedEventArgs e)
        {
            if ((txtAnswers.Text == "0") || (IsOperation))
            {
                txtAnswers.Clear();
            }
            IsOperation = false;

            if (!AfterEquals)
                txtAnswers.Text = txtAnswers.Text + "3";
        }

        private void Btn4_Click(object sender, RoutedEventArgs e)
        {
            if ((txtAnswers.Text == "0") || (IsOperation))
            {
                txtAnswers.Clear();
            }
            IsOperation = false;

            if (!AfterEquals)
                txtAnswers.Text = txtAnswers.Text + "4";
        }

        private void Btn5_Click(object sender, RoutedEventArgs e)
        {
            if ((txtAnswers.Text == "0") || (IsOperation))
            {
                txtAnswers.Clear();
            }
            IsOperation = false;

            if (!AfterEquals)
                txtAnswers.Text = txtAnswers.Text + "5";
        }

        private void Btn6_Click(object sender, RoutedEventArgs e)
        {
            if ((txtAnswers.Text == "0") || (IsOperation))
            {
                txtAnswers.Clear();
            }
            IsOperation = false;

            if (!AfterEquals)
                txtAnswers.Text = txtAnswers.Text + "6";
        }

        private void Btn7_Click(object sender, RoutedEventArgs e)
        {
            if ((txtAnswers.Text == "0") || (IsOperation))
            {
                txtAnswers.Clear();
            }
            IsOperation = false;

            if (!AfterEquals)
                txtAnswers.Text = txtAnswers.Text + "7";
        }

        private void Btn8_Click(object sender, RoutedEventArgs e)
        {
            if ((txtAnswers.Text == "0") || (IsOperation))
            {
                txtAnswers.Clear();
            }
            IsOperation = false;

            if(!AfterEquals)
            txtAnswers.Text = txtAnswers.Text + "8";
        }

        private void Btn9_Click(object sender, RoutedEventArgs e)
        {
            if ((txtAnswers.Text == "0") || (IsOperation))
            {
                txtAnswers.Clear();
            }
            IsOperation = false;

            if (!AfterEquals)
            txtAnswers.Text = txtAnswers.Text + "9";
        }

        private void BtnPlus_Click(object sender, RoutedEventArgs e)
        {
            Operation = "+";
            Results = double.Parse(txtAnswers.Text);
            IsOperation = true;

            AfterEquals = false;
        }

        private void BtnMinus_Click(object sender, RoutedEventArgs e)
        {
            Operation = "-";
            Results = double.Parse(txtAnswers.Text);
            IsOperation = true;

            AfterEquals = false;
        }

        private void BtnTimes_Click(object sender, RoutedEventArgs e)
        {
            Operation = "*";
            Results = double.Parse(txtAnswers.Text);
            IsOperation = true;

            AfterEquals = false;
        }

        private void BtnDivide_Click(object sender, RoutedEventArgs e)
        {
            Operation = "/";
            Results = double.Parse(txtAnswers.Text);
            IsOperation = true;

            AfterEquals = false;
        }

        private void BtnEquils_Click(object sender, RoutedEventArgs e)
        {
            
            switch (Operation)
            {
                case "+":
                    txtAnswers.Text = (Results + double.Parse(txtAnswers.Text)).ToString();
                    break;
                case "-":
                    txtAnswers.Text = (Results - double.Parse(txtAnswers.Text)).ToString();
                    break;
                case "*":
                    txtAnswers.Text = (Results * double.Parse(txtAnswers.Text)).ToString();
                    break;
                case "/":
                    txtAnswers.Text = (Results / double.Parse(txtAnswers.Text)).ToString();
                    break;

                    
            }//end switch
            AfterEquals = true;
            
        }

        private void btnC_Click(object sender, RoutedEventArgs e)
        {
            txtAnswers.Text = "0";
            Results = 0;
            AfterEquals = false;
        }

        private void BtnPostiveNegative_Click(object sender, RoutedEventArgs e)
        {
            if((txtAnswers.Text == "0") || (IsOperation))
            {
                number1 *= -1;
                txtAnswers.Text  = number1.ToString();
            }

            else
            {
                number2 *= -2;
                txtAnswers.Text = number2.ToString();
            }
        }

        private void BtnBack_Click(object sender, RoutedEventArgs e)
        {
            
            {
                txtAnswers.Clear();
            }


        }

        private void btnCE_Click(object sender, RoutedEventArgs e)
        {
            if ((txtAnswers.Text == "0") || (IsOperation))
            {
                number1 = 0;
            }
            else
            {
                number2 = 0;
            }
            txtAnswers.Text = "0";
            AfterEquals = false;
        }
    }
}
