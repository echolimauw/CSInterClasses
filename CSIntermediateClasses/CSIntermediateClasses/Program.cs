using System;

namespace CSIntermediateClasses
{
    partial class Program
    {
        static void Main(string[] args)
        {
            var customer = new Customer(1, "Jim");
            Console.WriteLine(customer.Id);
            Console.WriteLine(customer.Name);
        }
    }
}
