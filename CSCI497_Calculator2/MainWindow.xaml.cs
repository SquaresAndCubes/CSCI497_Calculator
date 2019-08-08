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


        //fjiwojfie//
    public partial class MainWindow : Window
    {
        //############### CREATE NEW OBJECT INSTANCE OF CALCULATOR CLASS ########################
        Calculator thisCalculator = new Calculator();
        //#######################################################################################

        //################# FUNCTIONS FOR BUTTON ENTRIES ########################################
        ///Function to pass numbers from GUI to Calculator Class and display input to GUI screen
        void guiNumEntry(int num)
            {
            //checks to see if any calculation has been performed if so a number button will clear screen
            if(thisCalculator.afterEquals == true)
                {
                txtAnswers.Clear();
                }
            //calls Calculator to pass it numbers for entry to the operation.
            thisCalculator.NumEntry(num.ToString());
            txtAnswers.Text = txtAnswers.Text + num.ToString();
            thisCalculator.afterEquals = false;
            }

        //function for all operation buttons of GUI
        void guiOperationEntry(String oper)
            {
            thisCalculator.operation = oper;
            txtAnswers.Clear();
            }
        //######################## END FUNCTIONS FOR BUTTON ENTRIES ################################

        //Initializes the MainWindow GUI Object
        public MainWindow()
        {
            InitializeComponent();
        }

        //############################### NUMBER BUTTONS ##########################################//
        private void Btn0_Click(object sender, RoutedEventArgs e)
        {
            //calls function for number entries
            guiNumEntry(0);
        }

        private void Btn1_Click(object sender, RoutedEventArgs e)
        {
            guiNumEntry(1);
        }

        private void Btn2_Click(object sender, RoutedEventArgs e)
        {
            guiNumEntry(2);
        }

        private void Btn3_Click(object sender, RoutedEventArgs e)
        {
            guiNumEntry(3);
        }

        private void Btn4_Click(object sender, RoutedEventArgs e)
        {
            guiNumEntry(4);
        }

        private void Btn5_Click(object sender, RoutedEventArgs e)
        {
            guiNumEntry(5);
        }

        private void Btn6_Click(object sender, RoutedEventArgs e)
        {
            guiNumEntry(6);
        }

        private void Btn7_Click(object sender, RoutedEventArgs e)
        {
            guiNumEntry(7);
        }

        private void Btn8_Click(object sender, RoutedEventArgs e)
        {
            guiNumEntry(8);
        }

        private void Btn9_Click(object sender, RoutedEventArgs e)
        {
            guiNumEntry(9);
        }

        //####################### END NUMBER BUTTONS ############################################

        
        //##################### MATH OPERATION BUTTONS ##########################################
        private void BtnPlus_Click(object sender, RoutedEventArgs e)
        {
            //calls function for operation entries
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
            if(thisCalculator.number1 != "" && thisCalculator.number2 != "" && thisCalculator.operation != "")
                {
                txtAnswers.Text = thisCalculator.Calculate();
                thisCalculator.afterEquals = true;
                thisCalculator.Clear();
                }
        }

              
        //######################### END MATH OPERATION BUTTONS ###################################


        //####################### BUTTONS FOR CLEARING AND BACKSPACE ###############################
        private void btnC_Click(object sender, RoutedEventArgs e)
        {
            txtAnswers.Clear();
            thisCalculator.Clear();
        }

        //Backspace current entry
        private void BtnBack_Click(object sender, RoutedEventArgs e)
        {
            if(thisCalculator.afterEquals == false)
            {
                thisCalculator.Backspace();
                txtAnswers.Text = txtAnswers.Text.Remove(txtAnswers.Text.Length - 1, 1);
            }
            
        }

        //Clears only the number that you are currently working on.
        private void btnCE_Click(object sender, RoutedEventArgs e)
        {
            //calls calculator clear CE function
            thisCalculator.ClearCE();
            //clears screen
            txtAnswers.Clear();
        }

        private void BtnPositiveNegative_Click(object sender, RoutedEventArgs e)
        {
            txtAnswers.Text = thisCalculator.PosNag();
        }
    }
    
}
