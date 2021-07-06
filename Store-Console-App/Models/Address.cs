using System;

namespace Models
{
    public class Address
    {
        //properties
        public int ID { get; set; }
        public string AddressLine1 { get; set; }
        public string AddressLine2 { get; set; }

        public string City { get; set; }
        public string State { get; set; }

        public DateTime LastUpdate { get; set; }

        // Constructors

        public Address()
        {

        }

        public Address(string addressLine1, string addressLine2, string city, string state)
        {
            AddressLine1 = addressLine1;
            AddressLine2 = addressLine2;
            City = city;
            State = State;
        }

        // Methods

        public override ToString()
        {
            return AddressLine1 + Environment.NewLine
            + AddressLine2 + Environment.NewLine
            + City + ", " + State
        }







    }
}