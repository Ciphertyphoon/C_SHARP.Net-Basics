using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace if_else_statement
{
    class If_else1
    {
        static void Main(string[] args)
        {
            /* local variable definition */
            int a = 100;

            /* check the boolean condition */
            if (a == 10)
            {
                /* if condition is true then print the following */
                Console.WriteLine("Value of a is 10");
            }
            else if (a == 20)
            {
                /* if else if condition is true */
                Console.WriteLine("Value of a is 20");
            }
            else if (a == 30)
            {
                /* if else if condition is true  */
                Console.WriteLine("Value of a is 30");
            }
            else
            {
                /* if none of the conditions is true */
                Console.WriteLine("None of the values is matching");
            }
            Console.WriteLine("Exact value of a is: {0}", a);
            Console.ReadLine();
        }
    }
}
