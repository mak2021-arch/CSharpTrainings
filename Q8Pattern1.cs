using System;
namespace C_
{
    class Q7Pattern1
    {
        static void Main(String[] args)
        {
           for (int i=1;i<=5;i++)
            {
                for (int j=1;j<=(5-i);j++)
                    Console.Write(" ");
                for (int num=1;num<= i;num++)
                    Console.Write(num);
                for (int num=(i-1);num>=1;num--)
                    Console.Write(num);
                Console.WriteLine();
            } 
            }
        }
    }