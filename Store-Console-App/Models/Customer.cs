using System;
using System.Collections.Generic;

namespace Models
{
    public class Customer
    {
        // properties

        public int ID { get; set; }
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string ContactInfo { get; set; }

        public DateTime LastUpdate { get; set; }

        //Constructors

        public Customer()
        {

        }

        public Customer(int id, string firstName, string lastName)
        {
            ID = id;
            FirstName = firstName;
            LastName = lastName;

        }

        // methods

        public void SetInfo(ContactInfo contactInfo)
        {
            ContactInfo = contactInfo;
        }















    }

}