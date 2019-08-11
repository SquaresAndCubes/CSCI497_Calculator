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
        bool isNumber = false;
        int operation_num = 0;
        char[] charsToTrim = { '+', '-', '*', '/' };

        //############### CREATE NEW OBJECT INSTANCE OF CALCULATOR CLASS ########################
        Calculator thisCalculator = new Calculator();
        //#######################################################################################

        //function for number buttons
        void guiNumEntry(String num)
        {
            if (afterEquals == true)
            {
                txtAnswers.Clear();
            }
            if (isOperation == true)
            {
                txtAnswers.Clear();
                txtAnswers.AppendText(num);
                isOperation = false;
            }
            else
            {
                txtAnswers.AppendText(num);
                isNumber = true;
            }
            isOperation = false;
        }

        //function for operation buttons
        void guiOperationEntry(String operation)
        {

            if(isNumber == true)
            {
                runningInput.AppendText(txtAnswers.Text);
                runningInput.AppendText(operation);
            }
            else if (operation_num >= 1)
            {
                runningInput.AppendText(txtAnswers.Text);
                txtAnswers.Text = thisCalculator.Calculate(runningInput.Text);
                runningInput.AppendText(operation);
            }

            isOperation = true;
            isNumber = false;
            operation_num += 1;
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
            
            if (operation_num <= 1)
            {
                runningInput.AppendText(txtAnswers.Text);
                txtAnswers.Clear();
                txtAnswers.Text = thisCalculator.Calculate(runningInput.Text);
                runningInput.Clear();
            }

            else
            {
                runningInput.Text = runningInput.Text.TrimEnd(charsToTrim);
                txtAnswers.Text = thisCalculator.Calculate(runningInput.Text);
                runningInput.Clear();
            }
            afterEquals = true;
        }

        private void BtnPostiveNegative_Click(object sender, RoutedEventArgs e)
        {
            txtAnswers.Text = thisCalculator.PosNeg(txtAnswers.Text);
        }
        //######################### END MATH OPERATION BUTTONS ###################################


        //####################### BUTTONS FOR CLEARING AND BACKSPACE ###############################
        private void btnC_Click(object sender, RoutedEventArgs e)
        {
            afterEquals = false;
            isOperation = false;
            isNumber = false;
            operation_num = 0;
            txtAnswers.Clear();
            runningInput.Clear();
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
            txtAnswers.Clear();
        }
    }
}
