using System;
using System.Collections.Generic;
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

        public String FizzBuzz()
        {
            String fizz = "";

            for (int i = FirstNumber; i <= SecondNumber; i++)
            {
                if ((i % 3 == 0) && (i % 5 == 0)) 
                {
                    fizz += "FizzBuzz ";
                }
                else if (i % 3 == 0)
                {
                    fizz += "Fizz ";
                }
                else if (i % 5 == 0)
                {
                    fizz += "Buzz ";
                }
                else
                {
                    fizz += i + " ";
                }

            }

            return fizz;
        }




    }
}