using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            //create instance of Calculator class
            Calculator c1 = new Calculator();

            //create instance of ExCalculator class, whitch inherit Calculator class
            ExCalculator c2 = new ExCalculator();

            c2.Num1 = 10;
            c2.Num2 = 3;
            //display result of addtion and subtraction
            c2.Add();
            c2.Sub();
            //display result of multiplication and division
            c2.Mul();
            c2.Div();
        }
    }
}
