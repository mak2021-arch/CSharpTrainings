using System;
namespace C_
{
    class Address
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Your Name");
            string name=Console.ReadLine();
            Console.WriteLine("Enter Your City");
            string city=Console.ReadLine();
            Console.WriteLine("Enter your Street Name");
            string street=Console.ReadLine();
            Console.WriteLine("Enter your Pin Code");
            int pin = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter your House No.");
            string hno = Console.ReadLine();
            Console.WriteLine("Your Full Address is");
            Console.WriteLine(name + '\n' + city + '\n' + street + '\n' + pin + '\n' + hno);            
        }
    }
}
