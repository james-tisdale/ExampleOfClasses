using System;

namespace ExampleOfClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            var nintendoSwitch = new Product();
            nintendoSwitch.Price = 299.99;
            nintendoSwitch.Name = "Nintendo Switch";
            Console.WriteLine(nintendoSwitch.Name + " " + nintendoSwitch.Price);
        }
    }
}
