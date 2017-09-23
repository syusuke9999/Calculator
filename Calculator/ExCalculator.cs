using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    //ExCalculator class whitch inherit Calculator class
    class ExCalculator : Calculator
    {
        //multiplication
        public void Mul() {
            Console.WriteLine("{0} * {1} = {2}", num1, num2, num1 * num2);
        }
        //division
        public void Div() {
            if (num2 == 0) {
                Console.WriteLine("Divided by Zero");
            }
            else {
                Console.WriteLine("{0} / {1} = {2}", num1, num2, num1 / num2);
            }
        }
    }
}
