using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace financialManagementProject
{
    class CashBalance
    {
        public static int CASH_BALANCE = 99500;

        public int Amount { get; set; };
    }
    public CashBalance(int amount)
    {
        this.Amount = amount;
    }
}
