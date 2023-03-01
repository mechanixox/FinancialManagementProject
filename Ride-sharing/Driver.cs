using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ride_sharing
{
    public class Driver : User
    {
        public string DriversLicense { get; private set; }
        public Driver(string name, DateTime birthdate, string contact, string driversLicense) : base(name, birthdate, contact)
        {
            this.DriversLicense = driversLicense;
        }
    }
}
