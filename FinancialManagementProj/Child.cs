using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinancialManagementProj
{
    class Child : User
    {
        public Activity Activity { get; private set; }
        public Child(string name, MemberType member, string contactInfo, string birthDate, Activity activity) : base(name, member, contactInfo, birthDate)
        {
            this.Activity = activity;
        }
    }
}
