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


            Console.WriteLine("Input first number");
            var n1 = int.Parse(Console.ReadLine());

            Console.Write("Input second number");
            var n2 = int.Parse(Console.ReadLine());

            c2.Num1 = n1;
            c2.Num2 = n2;

            //display result of addtion and subtraction
            c2.Add();
            c2.Sub();
            //display result of multiplication and division
            c2.Mul();
            c2.Div();
        }
    }
}
