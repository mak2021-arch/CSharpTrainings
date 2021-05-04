using System;
namespace C_
{
    class power
    {
        static void Main(String[] args)
        {
            Condition:
            Console.WriteLine("Enter a number");
            double num = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the power");
            int pow = Convert.ToInt32(Console.ReadLine());
            double pnum = Math.Pow(num, pow);
            Console.WriteLine("The Number is :{0}",pnum);
            Console.WriteLine("The power is :{0}",pow);
            Console.WriteLine("Do you want to continue? Press 'Y'!");
            char a =Convert.ToChar(Console.ReadLine());
            while(a=='y'||a=='Y')
            {
            goto Condition;
            }
        }

        }
    }