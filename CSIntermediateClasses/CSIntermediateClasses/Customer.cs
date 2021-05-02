using System;
using System.Collections.Generic;

namespace CSIntermediateClasses
{
    public class Customer
    {
        public int Id;
        public string Name;
        public readonly List<Order> Orders = new();

        /*public Customer()
        {
            Orders = new List<Order>();
        }*/

        public Customer(int id)
        {
            this.Id = id;
        }
        
        public Customer(int id, string name)
            : this(id)
        {
            this.Name = name;
        }
    }
}
