using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Web;

namespace FizzBuzz_App.Models
{
    public class fizzbuzzer
    {

        public int FirstNumber { get; set; }
        public int SecondNumber { get; set; }
        public String Result { get; set; }

        

        public bool CheckSame()
        {
            if (FirstNumber == SecondNumber) {
                return true;
            }
            return false;
        }

        public bool CheckBoundaries()
        {
            if (((FirstNumber <= 0 || FirstNumber > 100)) || ((SecondNumber <= 0 || SecondNumber > 100)))
            {
                return true;
            }
            return false;
        }

        public bool CheckOrder()
        {
            if (FirstNumber > SecondNumber)
            {
                return true;
                       
            }
            return false;
        }

        public void Reorder()
        {            
             int temp1 = FirstNumber;
             int temp2 = SecondNumber;

             FirstNumber = temp2;
             SecondNumber = temp1;            
            
        }

        public void FizzBuzz()
        {
            string answer = "";

            for (int i = FirstNumber; i <= SecondNumber; i++)
            {
                if ((i % 3 == 0) && (i % 5 == 0)) 
                {
                    answer += "FizzBuzz \n";
                }
                else if (i % 3 == 0)
                {
                    answer += "Fizz \n";
                }
                else if (i % 5 == 0)
                {
                    answer += "Buzz \n";
                }
                else
                {
                    answer += i + " \n";
                }

            }

            Result = answer;

            
        }




    }
}