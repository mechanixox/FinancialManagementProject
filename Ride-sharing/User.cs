using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ride_sharing
{
    internal abstract class User
    {
        public string Name { get; private set; }
        public DateTime BirthDate { get; private set; }
        public Point Location { get; set; }
        public string Contact { get; set; }
        public User(string name, DateTime birthdate, string contact)
        {
            this.Name = name;
            this.BirthDate = birthdate;
            this.Location = Point.Empty;
            this.Contact = contact;
        }
    }
}
