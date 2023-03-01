using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinancialManagementProj
{
    abstract class User
    {
        public string? Name { get; private set; }
        public MemberType Member { get; set; }
        public string ContactInfo { get; set; }
        public string BirthDate { get; set; }
        public User(string name, MemberType member, string contactInfo, string birthDate)
        {
            this.Name = name;
            this.Member = member;
            this.ContactInfo = contactInfo;
            this.BirthDate = birthDate;
        }
    }
 

}
