//CSCI497 Capstone
//Davenport University
//Summer 2019 Semester
//Prof. Brian Kowalczk
//Team 1
//Calculator w/ Loose Coupling Implementation

//Import dependencies
using System;
using System.Windows;

namespace CSCI497_Calculator2
{
    //##################################################################################################//
    //##################### MAINWINDOW CLASS (USER INTERFACE) ##########################################//
    //##################################################################################################//

    public partial class MainWindow : Window
    {
        bool afterEquals = false;
        bool isOperation = false;

        //############### CREATE NEW OBJECT INSTANCE OF CALCULATOR CLASS ########################
        Calculator thisCalculator = new Calculator();
        //#######################################################################################

        //function for number buttons
        void guiNumEntry(String num)
        {
            if (afterEquals == true)
            {
                txtAnswers.Clear();
                afterEquals = false;
            }
            txtAnswers.AppendText(num);
            isOperation = false;
        }

        //function for operation buttons
        void guiOperationEntry(String operation)
        {
            if (isOperation == false)
            {
                txtAnswers.AppendText(operation);

            }
            isOperation = true;
        }

        //Initializes the MainWindow GUI Object
        public MainWindow()
        {
            InitializeComponent();
        }

        //############################### NUMBER BUTTONS ##########################################//
        private void Btn0_Click(object sender, RoutedEventArgs e)
        {
            guiNumEntry("0");
        }

        private void Btn1_Click(object sender, RoutedEventArgs e)
        {
            guiNumEntry("1");
        }

        private void Btn2_Click(object sender, RoutedEventArgs e)
        {
            guiNumEntry("2");
        }

        private void Btn3_Click(object sender, RoutedEventArgs e)
        {
            guiNumEntry("3");
        }

        private void Btn4_Click(object sender, RoutedEventArgs e)
        {
            guiNumEntry("4");
        }

        private void Btn5_Click(object sender, RoutedEventArgs e)
        {
            guiNumEntry("5");
        }

        private void Btn6_Click(object sender, RoutedEventArgs e)
        {
            guiNumEntry("6");
        }

        private void Btn7_Click(object sender, RoutedEventArgs e)
        {
            guiNumEntry("7");
        }

        private void Btn8_Click(object sender, RoutedEventArgs e)
        {
            guiNumEntry("8");
        }

        private void Btn9_Click(object sender, RoutedEventArgs e)
        {
            guiNumEntry("9");
        }

        private void btnPeriod_Click(object sender, RoutedEventArgs e)
        {
            guiNumEntry(".");
        }

        //####################### END NUMBER BUTTONS ############################################


        //##################### MATH OPERATION BUTTONS ##########################################
        private void BtnPlus_Click(object sender, RoutedEventArgs e)
        {
            guiOperationEntry("+");
        }

        private void BtnMinus_Click(object sender, RoutedEventArgs e)
        {
            guiOperationEntry("-");

        }

        private void BtnTimes_Click(object sender, RoutedEventArgs e)
        {
            guiOperationEntry("*");
        }

        private void BtnDivide_Click(object sender, RoutedEventArgs e)
        {
            guiOperationEntry("/");
        }

        //################ PERFORM CALCULATON BUTTON (EQUALS) ####################################
        private void BtnEquils_Click(object sender, RoutedEventArgs e)
        {
            txtAnswers.Text = thisCalculator.Calculate(txtAnswers.Text);
            afterEquals = true;
        }

        private void BtnPostiveNegative_Click(object sender, RoutedEventArgs e)
        {
            //TBD

        }
        //######################### END MATH OPERATION BUTTONS ###################################


        //####################### BUTTONS FOR CLEARING AND BACKSPACE ###############################
        private void btnC_Click(object sender, RoutedEventArgs e)
        {
            txtAnswers.Clear();
        }

        //Backspace current entry
        private void BtnBack_Click(object sender, RoutedEventArgs e)
        {
            //backspace until the string is of 0 length
            if (txtAnswers.Text.Length != 0)
            {
                txtAnswers.Text = txtAnswers.Text.Remove(txtAnswers.Text.Length - 1, 1);
            }

        }

        //Clears only the number that you are currently working on.
        private void btnCE_Click(object sender, RoutedEventArgs e)
        {
            //trims the numbers off past the last operation
            var digits = new[] { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9', '.' };
            txtAnswers.Text = txtAnswers.Text.TrimEnd(digits);
        }
    }
}
