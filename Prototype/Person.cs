using System;
using System.Collections.Generic;
using System.Text;

namespace Prototype
{
    public class Person
    {
        public string Name { get; set; }
        public Address Address { get; set; }
    }

    public class Address : ICloneable
    {
        public string FlatNo { get; set; }
        public string StreetNo { get; set; }
        public string City { get; set; }
        public string Country { get; set; }

        public object Clone()
        {
            return MemberwiseClone();
        }

        public override string ToString()
        {
            return $"{FlatNo}, {StreetNo}, {City}, {Country}";
        }
    }
}
