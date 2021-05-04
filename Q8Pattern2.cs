using System;

namespace C_
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i=1;i<=5;i++)
            {
                for (int j=1;j<=(5-i);j++)
                    Console.Write(" ");
                for (int num=1;num<=i;num++)
                    Console.Write(num);
                for (int num=(i-1);num>=1;num--)
                    Console.Write(num);
                Console.WriteLine();
            }
 
            for (int i=(5 - 1);i>=1;i--)
            {
                for (int j=1;j<=(5-i);j++)
                    Console.Write(" ");
                for (int num=1;num<=i;num++)
                    Console.Write(num);
                for (int num=(i-1);num>=1;num--)
                    Console.Write(num);
                Console.WriteLine();
            }
            
        }
    }
}