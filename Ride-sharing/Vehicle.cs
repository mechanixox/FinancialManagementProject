using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ride_sharing
{
    public abstract class Vehicle
    {
        public int MaxCapacity { get; private set; }
        public Passenger[] passengers; 
        public Driver driver;

        public Vehicle(int maxCapacity, Driver driver) 
        {
            this.MaxCapacity = maxCapacity;
            this.passengers = new Passenger[maxCapacity];
            this.driver = driver;
        }
    }
}
