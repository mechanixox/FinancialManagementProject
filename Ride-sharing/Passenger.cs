using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ride_sharing
{
    public class Passenger : User
    {
        public double Mileage { get; private set; }
        //public string Contact { get; set; }
        public Passenger(string name, DateTime birthdate, Point location, string contact) : base(name, birthdate, location, contact)
        {
            this.Mileage = 0;

        }
    }
}
