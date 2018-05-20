using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticVarApplication
{
    class StaticVar
    {
        public static int num;

        public void count()
        {
            num++;
        }
        public int getNum()
        {
            return num;
        }
    }
}
