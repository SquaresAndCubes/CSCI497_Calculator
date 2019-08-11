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
    //######################### UNIT TEST CLASS ########################################################//
    //##################################################################################################//

    class UnitTest
    {
        Calculator testCalculator = new Calculator();

        public String additionTest()
        {

            if (testCalculator.Calculate("1+1") != "2")
            {
                return "1+1 Addition Test Fail";
            }
            else
            {
                return "1+1 Addition Test Passed!!";
            }
        }
        public String subtractionTest()
        {

            if (testCalculator.Calculate("10-5") != "5")
            {
                return "10-5 Subtraction Test Fail";
            }
            else
            {
                return "10-5 Subtraction Test Passed!!";
            }
        }
        public String multiplicationTest()
        {

            if (testCalculator.Calculate("2*2") != "4")
            {
                return "2*2 Multiplication Test Fail";
            }
            else
            {
                return "2*2 Multiplication Test Passed!!";
            }
        }
        public String divisionTest()
        {

            if (testCalculator.Calculate("10/2") != "5")
            {
                return "10/2 Division Test Fail";
            }
            else
            {
                return "10/2 Division Test Passed!!";
            }
        }
        public String multipleOperationsTest()
        {

            if (testCalculator.Calculate("10/2*3+21") != "36")
            {
                return "10/2*3+21 Multiple Operations Test Fail";
            }
            else
            {
                return "10/2*3+21 Multiple Operations Test Passed!!";
            }
        }
    }
}
