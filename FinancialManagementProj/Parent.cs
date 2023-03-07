using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinancialManagementProj
{
    class Parent : User
    {
        public string Occupation { get; private set; }
        public Parent(int id, string name, MemberType member, string contactInfo, string birthDate, string occupation) : base(name, member, contactInfo, birthDate)
        {
            this.Occupation = occupation;
        }
    }
}
