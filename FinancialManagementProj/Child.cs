﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinancialManagementProj
{
    class Child : User
    {
        public ChildActivity Activity { get; private set; }
        public Child(int id, string name, MemberType member, string contactInfo, string birthDate, ChildActivity activity) : base(id, name, member, contactInfo, birthDate)
        {
            this.Activity = activity;
        }
    }
}
