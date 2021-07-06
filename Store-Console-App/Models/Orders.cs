using System;
using System.Collections.Generic;
using Models;

namespace Models
{
    public class Orders
    {
        // properties
        public int ID { get; set; }

        public List<Detail> Details { get; set; }

        public Address Location { get; set; }

        public DateTime OrderDate { get; set; }

        public int CustomerID { get; set; }
        public Customer Customer { get; set; }

        public int StoreID { get; set; }

        public Store Store { get; set; }

        public DateTime LastUpdate { get; set; }

        // Constructors

        public Orders()
        {

        }
        public Orders(int id, Address orderLocation)
        {
            ID = id;
            Location = orderLocation;
            OrderDate = DateTime.UtcNow;

        }

        //Methods        
















    }
}


