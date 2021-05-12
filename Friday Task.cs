/*Qu : Write a program for creating a Car in which Engine, Tyre, Sound System should be defined in a base class. 
Your program should inherit all the functionality and gives custom color to a car using interface*/

using System;

namespace C_
{
    class Car
    {
       public string Engine = "V8 Twin Turbo";
       public string Tyre = "Goodyear Tyre";
       public string SoundSystem = "BOSE Surround Sound";

    }

    interface IColour
    {
        string CustomColour();
    }

    class CarModel : Car , IColour 
    {
        public string CustomColour()
        {
            Console.WriteLine("Enter Colour name that you want for your car");
            string col = Console.ReadLine();
            return col;
        }
    }

    class Program 
    {
        static void Main(string[] args)
        {
            CarModel obj = new CarModel();
            string a = obj.Engine;
            string b = obj.Tyre;
            string c = obj.SoundSystem;
            string d = obj.CustomColour();

            Console.WriteLine("\nENGINE : " + a + "\nTYRE : " + b + "\nSOUNDSYSTEM : " + c + "\nCOLOUR : " + d); 
        }
    }
} 
