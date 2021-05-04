using System;
namespace C_
{
    class power
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the base number");
            double num = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the power");
            double pow = Convert.ToDouble(Console.ReadLine());
            double pnum = Math.Pow(num, pow);
            Console.WriteLine("The number is :{0} \nPower is :{1}", pnum, pow);

        }
    }
}
