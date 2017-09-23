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
            //create instance of ExCalculator class, whitch inherit Calculator class
            FunctionCalculator calc = new FunctionCalculator();

            //Get first number from command line
            Console.WriteLine("Input first number");
            var n1 = int.Parse(Console.ReadLine());

            //Get second number from command line
            Console.WriteLine("Input second number");
            var n2 = int.Parse(Console.ReadLine());

            calc.Num1 = n1;
            calc.Num2 = n2;

            //display result of addtion and subtraction
            calc.Add();
            calc.Sub();

            //display result of multiplication and division
            calc.Mul();
            calc.Div();

            //display result of exponentiation and residue
            calc.Exp();
            calc.Modulo();
        }
    }
}
