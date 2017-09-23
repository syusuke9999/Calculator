using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Calculator
    {
        //first number
        protected int num1;
        //second number
        protected int num2;

        //property of first number
        public int Num1{
            set{
                num1 = value;
            }
            get{
                return num1;
            }
        }
        //property of second number
        public int Num2 {
            set {
                num2 = value;
            }
            get {
                return num2;
            }
        }
        //addtion
        public void Add() {
            Console.WriteLine("{0} + {1} = {2}", num1, num2, num1 + num2);
        }
        //subtraction
        public void Sub() {
            Console.WriteLine("{0} - {1} = {2}", num1, num2, num1 - num2);
        }
    }
}
