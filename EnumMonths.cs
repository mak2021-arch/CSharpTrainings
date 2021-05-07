using System;

namespace MyApplication
{
  class Program
  {
    enum Months
    {
      January,    // 0
      February,   // 1
      March,      // 2
      April,      // 3
      May,        // 4
      June,       // 5
      July,       // 6
      August,     // 7
      September,  // 8
      October,    // 9
      November,   // 10
      December,   // 11
    }
    static void Main(string[] args)
    {
        Year:
        Console.WriteLine("Enter the first letter of month:");
        String c= Console.ReadLine();
        Console.WriteLine("All months with this letter:");
        if(c=="j"||c=="J")
        {
            Console.WriteLine(Months.January);
            Console.WriteLine(Months.June);
            Console.WriteLine(Months.July);
        }
        else if(c=="f"||c=="F")
        { 
            Console.WriteLine(Months.February);
        }
        else if(c=="m"||c=="M")
        {
            Console.WriteLine(Months.March);
            Console.WriteLine(Months.May);
        }
        else if(c=="a"||c=="A")
        {
            Console.WriteLine(Months.April);
            Console.WriteLine(Months.August);
        }
        else if(c=="s"||c=="S")
        {
            Console.WriteLine(Months.September);
        }
        else if(c=="o"||c=="O")
        {
            Console.WriteLine(Months.October);
        }
        else if(c=="n"||c=="N")
        {
            Console.WriteLine(Months.November);
        }
        else if(c=="d"||c=="D")
        {
            Console.WriteLine(Months.December);
        }
        else
        {
            Console.WriteLine("-----------------\nERROR\n-----------------\n'Please input correct alphabet'\n");
            goto Year;
        }

  }
}
}