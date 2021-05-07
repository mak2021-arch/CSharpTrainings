/*Qu : Write a program for creating a Car in which Engine, Tyre, Sound System should be defined in a base class. 
Your program should inherit all the functionality and gives custom color to a car using interface*/

using System;

namespace C_
{
    class Car
    {
        public static void Main()
        {
            Var v= new CC();
                
            }
    }

    interface Var
    {
     void Color();

    }

    class CC : Var
    {
        override Var.Color()
        {
            Console.WriteLine("Color is : Red");
        }
    }
}
