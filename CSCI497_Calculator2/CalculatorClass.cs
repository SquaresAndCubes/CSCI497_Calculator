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

        System.Data.DataTable dataTable = new System.Data.DataTable();

        public String Calculate(String eval)
        {

            
            //Returns the answer as string
            return dataTable.Compute(eval, null).ToString();
        }

        }
    }