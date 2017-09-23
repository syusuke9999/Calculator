using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class FunctionCalculator : ExCalculator
    {
        //exponentiation
        public void Exp(){
            Console.WriteLine("{0} ^ {1} = {2}", num1, num2, num1 ^ num2);
        }
        //residue
        public void Modulo(){
            Console.WriteLine("{0} % {1} = {2}", num1, num2, num1 % num2);
        }
    }
}
