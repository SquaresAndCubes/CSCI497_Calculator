//CSCI497 Capstone
//Davenport University
//Summer 2019 Semester
//Prof. Brian Kowalczk
//Team 1
//Calculator w/ Loose Coupling Implementation

//Import dependencies
using System;

namespace CSCI497_Calculator2
{
    //##################################################################################################//
    //######################### CALCULATOR CLASS (LOGIC ONLY) ##########################################//
    //##################################################################################################//
    public class Calculator
    {
        public String number1 = "";
        public String number2 = "";
        public String zeroDivide = "Can't / by Zero";
        double posNeg = 0;
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

                    if(number2 == "0")
                    {
                        return zeroDivide;
                    }
                    else
                    {
                        results = double.Parse(number1) / double.Parse(number2);
                    }
                    
                    break;

            }//end switch

            //Clears variables to get ready for next operation
            Clear();
            //Returns the answer as string
            return results.ToString();
        }
        //funcion clears current entry
        public void ClearCE()
        {
            if (number2 != "")
            {
                number2 = "";
            }
            else
            {
                number1 = "";
            }
        }

        //function backspaces the current entry
        public void Backspace()
        {
            if(afterEquals == false)
            {
                if (number2 != "")
                {
                    number2 = number2.Remove(number2.Length - 1, 1);
                }
                else
                {
                    number1 = number1.Remove(number1.Length - 1, 1);
                }
            }

        }
        public String PosNag()
        {
            
                if(number2 != "")
                {
                    posNeg = double.Parse(number2) * -1;

                    number2 = Convert.ToString(posNeg);

                    posNeg = 0;

                    return number2.ToString();
                }
                else if(results != 0)
            {
                results = results * -1;

                return results.ToString();
            }
                else
                {
                    posNeg = double.Parse(number1) * -1;

                    number1 = Convert.ToString(posNeg);

                    posNeg = 0;

                    return number1.ToString();
                }
                
           
        }
    }
}