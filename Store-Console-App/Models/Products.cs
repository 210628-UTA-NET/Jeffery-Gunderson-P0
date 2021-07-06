using System;
using System.Collections.Generic;


namespace Models
{

    public class Products
    {
        // Properties
        public int ID { get; set; }
        public string Name { get; set; }

        public string Description { get; set; }
        public decimal Price { get; set; }

        public string Category { get; set; }
        public int StoreID { get; set; }

        public DateTime LastUpdate { get; set; }

        // Constructors

        public Products()
        {

        }

        public Products(int id, string name, string description, string category)
        {
            ID = id;
            Name = name;
            Description = description;
            Category = category;

        }

        // Methods
        public void SetPrice(decimal price)
        {
            Price = price;
        }











    }
