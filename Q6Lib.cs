using System;
namespace C_
{
    class lib
    {
        static void Main(String[] args)
        {   
            Choice:
            char a;
            Console.WriteLine("Enter your Choice");
            Console.WriteLine("Option: \nc: for computer books \nm: for mathematical books \nh: for history books \ne: for English books");
            a = Convert.ToChar(Console.ReadLine());
        switch (a)
        {
            case 'c':
            Console.WriteLine("You have selected Computer");
            break;

            case 'm':
            Console.WriteLine("You have selected Mathematics");
            break;

            case 'h':
            Console.WriteLine("You have selected History");
            break;

            case 'e':
            Console.WriteLine("You have selected English");
            break;

            default:
            Console.WriteLine("Enter a Valid Option and try again");  
            goto Choice;        
        }
            
            
        }
    }
}