using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace break_statement
{
   class Program {
      static void Main(string[] args) {
         /* local variable definition */
         int a = 10;
         
         /* while loop execution */
         while (a < 20) {
            Console.WriteLine("value of a: {0}", a);
            a++;
            
            if (a > 18) {
               /* terminate the loop using break statement */
               break;
            }
         }
         Console.ReadLine();
      }
   }
}
