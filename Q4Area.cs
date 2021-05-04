using System;
namespace C_
{
    class Area
    {
        static void Main(String [] args)
        {
            Console.WriteLine("Enter the value of Base");
            double bas = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter The Value of Height");
            double hei = Convert.ToDouble(Console.ReadLine());
            double area = (bas*hei)/2;
            Console.WriteLine("The Area is :{0} ", area);
        }
    }
}