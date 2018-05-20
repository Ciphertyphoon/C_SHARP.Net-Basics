using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceApplication
{
    public interface ITransactions
    {
        // interface members
        void showTransaction();
        double getAmount();
    }
}
