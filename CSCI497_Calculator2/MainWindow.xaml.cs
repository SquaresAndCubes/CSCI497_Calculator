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

        public bool afterEquals = false;
        public String entry = "";
        public double results = 0;
        public String operation = "";
        
        //resets the calculator
        public void Clear()
        {
            entry = "";
            operation = "";
        }

        //puts first number input as result
        public void SetResult()
            {
            results = Double.Parse(entry);
            entry = "";
            }

        //function for number entry appends input to entry string
        public void NumEntry(String num_in)
            {
            entry = entry + num_in;
            }
        
        public String Calculate()
            {

            //Takes the operation variable as input and determines the correct mathmatical operation to perform.
            switch (operation)
            {
                case "+":
                    results = results + Double.Parse(entry);
                    break;
                case "-":
                    results = results - Double.Parse(entry);
                    break;
                case "*":
                    results = results * Double.Parse(entry);
                    break;
                case "/":
                    results = results / Double.Parse(entry);
                    break;
                    
            }//end switch

            afterEquals = true;
            //Clears variables to get ready for next operation
            Clear();
            //Returns the answer as string
            return results.ToString();
            //nothing will run here because of ^ return above
            }
        }


   
    //##################################################################################################//
    //##################### MAINWINDOW CLASS (USER INTERFACE) ##########################################//
    //##################################################################################################//

    public partial class MainWindow : Window
    {

        //Create new object instance of Calculator class
        Calculator thisCalculator = new Calculator();

        ///Function to pass numbers from GUI to Calculator Class and display input to GUI screen
        void guiNumEntry(int num)
            {
            //when user types in number after equals this clears the screen
            if(thisCalculator.afterEquals == true)
                {
                txtAnswers.Clear();
                }
            //calls Calculator to pass it numbers for entry to the operation.
            thisCalculator.NumEntry(num.ToString());
            txtAnswers.Text = txtAnswers.Text + num.ToString();
            }

        //function for operation function of GUI
        void guiOperationEntry(String oper)
            {
            thisCalculator.SetResult();
            thisCalculator.operation = oper;
            txtAnswers.Clear();
            }

        //Initializes the MainWindow GUI Object
        public MainWindow()
        {
            InitializeComponent();
        }

        //Number Buttons

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

        //Math operation Buttons

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

        //Equals for asking the calc for an answer
        private void BtnEquils_Click(object sender, RoutedEventArgs e)
        {
            txtAnswers.Text = thisCalculator.Calculate();
        }

        //Button for clearing or resetting the calculator

        private void btnC_Click(object sender, RoutedEventArgs e)
        {
            txtAnswers.Clear();
            thisCalculator.Clear();
        }

        private void BtnPostiveNegative_Click(object sender, RoutedEventArgs e)
        {
            //to be added
        }

        private void BtnBack_Click(object sender, RoutedEventArgs e)
        {
            //to be added
        }

        private void btnCE_Click(object sender, RoutedEventArgs e)
        {
            //to be added
        }
    }
}
