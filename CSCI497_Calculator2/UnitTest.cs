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

    }





}
