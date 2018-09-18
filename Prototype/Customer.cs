using System;
using System.Collections.Generic;
using System.Text;

namespace Prototype
{
    public class Customer : ICloneable
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Address Address { get; set; }

        public object Clone()
        {
            return this.MemberwiseClone();
        }
    }

    public class Address : ICloneable
    {
        public string PrimaryAddress { get; set; }
        public string SecondaryAddress { get; set; }

        public object Clone()
        {
            return this.MemberwiseClone();
        }
    }
}
