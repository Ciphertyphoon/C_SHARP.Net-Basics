using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayApplication2
{
    class MyArray
    {
        static void Main(string[] args)
        {
            int[] n = new int[10]; /* n is an array of 10 integers */

            /* initialize elements of array n */
            for (int i = 0; i < 10; i++)
            {
                n[i] = i + 100;
            }

            /* output each array element's value */
            foreach (int j in n)
            {
                int i = j - 100;
                Console.WriteLine("Element[{0}] = {1}", i, j);
            }
            Console.ReadKey();
        }
    }
}
