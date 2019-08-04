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
}