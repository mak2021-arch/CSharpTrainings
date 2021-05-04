using System;
namespace C_
{
    class Address
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Your Name");
            string name=Console.ReadLine();
            Console.WriteLine("Enter Your Roll No.");
            int roll = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter your Age");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter your Class");
            int cls = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter your University");
            string uni = Console.ReadLine();
            Console.WriteLine("Your Full Information is:");
            Console.WriteLine("Name : {0} \nRoll No.: {1} \nAge: {2} \nClass: {3} \nUniversity: {4}", name, roll, age, cls, uni);            
        }
    }
}
