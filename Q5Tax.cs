using System;
namespace C_
{
    class tax
    {
        static void Main(String[] args)
        {
            double amt =0;
            Console.WriteLine("Enter the Amount of Money");
            double money = Convert.ToDouble(Console.ReadLine());
                if (money<=10000)
             { 
                    amt = money*0.05;
                    Console.WriteLine("Your Tax Amount is :{0}", amt); 
             }
                 else if(money>10000 && money<=100000)
             {
                  amt = money*0.08;
                  Console.WriteLine("Your Tax Amount is :{0}", amt);
             } 
                 else
             {
                  amt = money*0.085;
                  Console.WriteLine("Your Tax Amount is :{0}", amt);
             }
       }

    }
}