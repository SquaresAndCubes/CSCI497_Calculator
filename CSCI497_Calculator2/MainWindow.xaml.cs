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
    //Brents revision of code for separation of Calculator Logic from UI
    //Alpha version with Comments
    //Calulator class encapsulates all mathematical logic separate from the UI

    //##################################################################################################//
    //######################### CALCULATOR CLASS (LOGIC ONLY) ##########################################//
    //##################################################################################################//
    public class Calculator
        {
        public String number1 = "";
        public String number2 = "";
        double results = 0;
        public String operation = "";
        public bool afterEquals = false;

        //resets the calculator
        public void Clear()
        {
            number1 = "";
            number2 = "";
            operation = "";
        }
        //function for calculator to know what the first and second numbers are based on whether there has been
        //any operator input yet
        public void NumEntry(String num_in)
            {
            if (operation != "")
                {
                number2 = number2 + num_in;
                }
            else
                {
                number1 = number1 + num_in;
                }
            }
        public String Calculate()
            {

            //Takes the operation variable as input and determines the correct mathmatical operation to perform.
            switch (operation)
            {
                case "+":
                    results = double.Parse(number1) + double.Parse(number2);
                    break;
                case "-":
                    results = double.Parse(number1) - double.Parse(number2);
                    break;
                case "*":
                    results = double.Parse(number1) * double.Parse(number2);
                    break;
                case "/":
                    results = double.Parse(number1) / double.Parse(number2);
                    break;
                    
            }//end switch
            
            //Clears variables to get ready for next operation
            Clear();
            //Returns the answer as string
            return results.ToString();
            
            }
        }

    //##################################################################################################//
    //##################### MAINWINDOW CLASS (USER INTERFACE) ##########################################//
    //##################################################################################################//

    public partial class MainWindow : Window
    {

        //############### CREATE NEW OBJECT INSTANCE OF CALCULATOR CLASS ########################
        Calculator thisCalculator = new Calculator();
        //#######################################################################################

        //################# FUNCTIONS FOR BUTTON ENTRIES ########################################

        ///Function to pass numbers from GUI to Calculator Class and display input to GUI screen
        void guiNumEntry(int num)
            {
            //checks to see if an calculation has been performed if so a number button will clear screen
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

                private void BtnPostiveNegative_Click(object sender, RoutedEventArgs e)
        {

        }

        //######################### END MATH OPERATION BUTTONS ###################################

        //####################### BUTTONS FOR CLEARING AND BACKSPACE ###############################

        private void btnC_Click(object sender, RoutedEventArgs e)
        {
            txtAnswers.Clear();
            thisCalculator.Clear();
        }

        private void BtnBack_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnCE_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
