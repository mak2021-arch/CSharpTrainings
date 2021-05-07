using System;
using System.Collections.Generic;
  
class list {
    public static void Main(String[] args)
    {
        List<int> firstlist = new List<int>();
        List<string> secondlist = new List<string>();
        Console.WriteLine("Enter the type of list you want to make\n Type 1 for integer list or type 2 for string list");
        int n = Convert.ToInt32(Console.ReadLine());

        switch(n)
        {
            case 1:
            Console.WriteLine("Enter the no. of elements you want to insert in the Integer list:");
            int num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the elements in the list:");
            for(int i = 0;i<num;i++)
            {
                int j = Convert.ToInt32(Console.ReadLine());
                firstlist.Add(j);
            }
            for(int i=0; i<num; i++)
                {
                   int count = 1;
                    for(int j=i+1; j<num-1; j++)
                    {
                        if(firstlist[i]==firstlist[j])
                        {
                            count++;
                            firstlist[j] = 0;
                        }
                    }
                if(firstlist[i]!=0)
                    {
                        firstlist[i] = count;
                    }
            

                // Frequency Printing
                for(int k=0; k<num; k++)
                {
                    if(firstlist[k]!=0)
                    {
                        Console.Write("Frequency of {0} is {1}.\n", firstlist[k]);
                    }
            Console.WriteLine("Count Is: " + firstlist.Count);
                }
            }
                break;

            case 2:
            Console.WriteLine("Enter the no. of elements you want to insert in the String list:");
            int elements = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the elements in the list:");
            for(int i = 0;i< elements; i++)
            {
                string j = Console.ReadLine();
                secondlist.Add(j);
            }
            Console.WriteLine("Count Is: " + secondlist.Count);
            break;
            
            default:
            Console.WriteLine("-------------\n-------------\n 'Select from the given option'");
            break;
        }
        
    }
}