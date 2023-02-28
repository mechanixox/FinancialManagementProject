using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace financialManagementProject
{
    class PersonalAccount
    {
        public static int ACCOUNT_ID_COUNTER = 0;
        public string AccName { get; set; }
        public int Amount { get; private set; }

    }
    public PersonalAccount(string name)
    {
        this.Amount = amount;
    }
}
