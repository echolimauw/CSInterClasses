using System;

namespace CSIntermediateClasses
{
    partial class Program
    {
        static void Main(string[] args)
        {
            var point = new Point(15, 30);
            point.Move(new Point(45, 75));
            Console.WriteLine("Point is at ({0}, {1}).", point.X, point.Y);
            
            /*var customer = new Customer(1, "Jim");
            Console.WriteLine(customer.Id);
            Console.WriteLine(customer.Name);*/

        }
    }
}
