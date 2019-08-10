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
        //############### CREATE NEW OBJECT INSTANCE OF CALCULATOR CLASS ########################
        Calculator thisCalculator = new Calculator();
        //#######################################################################################


        //Initializes the MainWindow GUI Object
        public MainWindow()
        {
            InitializeComponent();
        }

        //############################### NUMBER BUTTONS ##########################################//
        private void Btn0_Click(object sender, RoutedEventArgs e)
        {
        }

        private void Btn1_Click(object sender, RoutedEventArgs e)
        {
        }

        private void Btn2_Click(object sender, RoutedEventArgs e)
        {
        }

        private void Btn3_Click(object sender, RoutedEventArgs e)
        {
        }

        private void Btn4_Click(object sender, RoutedEventArgs e)
        {
        }

        private void Btn5_Click(object sender, RoutedEventArgs e)
        {
        }

        private void Btn6_Click(object sender, RoutedEventArgs e)
        {
        }

        private void Btn7_Click(object sender, RoutedEventArgs e)
        {
        }

        private void Btn8_Click(object sender, RoutedEventArgs e)
        {
        }

        private void Btn9_Click(object sender, RoutedEventArgs e)
        {
        }

        //####################### END NUMBER BUTTONS ############################################

        
        //##################### MATH OPERATION BUTTONS ##########################################
        private void BtnPlus_Click(object sender, RoutedEventArgs e)
        {
        }

        private void BtnMinus_Click(object sender, RoutedEventArgs e)
        {
        }

        private void BtnTimes_Click(object sender, RoutedEventArgs e)
        {
        }

        private void BtnDivide_Click(object sender, RoutedEventArgs e)
        {
        }

        //################ PERFORM CALCULATON BUTTON (EQUALS) ####################################
        private void BtnEquils_Click(object sender, RoutedEventArgs e)
        {
        }

        private void BtnPostiveNegative_Click(object sender, RoutedEventArgs e)
        {

        }
        //######################### END MATH OPERATION BUTTONS ###################################


        //####################### BUTTONS FOR CLEARING AND BACKSPACE ###############################
        private void btnC_Click(object sender, RoutedEventArgs e)
        {
        }

        //Backspace current entry
        private void BtnBack_Click(object sender, RoutedEventArgs e)
        {
            
        }

        //Clears only the number that you are currently working on.
        private void btnCE_Click(object sender, RoutedEventArgs e)
        {
        }
    }
}
