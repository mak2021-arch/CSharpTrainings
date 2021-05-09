using System;
using System.Collections.Generic;

namespace C_
   { 
class Program
    {   
        public static void Main()
        {
            Listing:
            Console.WriteLine("Choose the type of list \n1. Integer; \n2. String;");
            int choice=Convert.ToInt32(Console.ReadLine());
            int num2=0;
            int count =0;

            if (choice==1)
            {   Number :
                Console.WriteLine("How many elements in Integer elements?");
                string num=Console.ReadLine();
                try
                {
                 num2=Convert.ToInt32(num);
                }
                catch(Exception) {
                    Console.WriteLine("--------------\nERROR\n--------------\n 'Please Enter Numbers only");
                    goto Number;
                }
                List <int> intlist = new List<int>();
                List <int> freqlist= new List<int>();
               /* Elements:
                Console.WriteLine("Enter the elements:");
                string num3;
                for (int i=0;i<num2;i++){
                     num3 = Console.ReadLine();
                     int num4;
                     try{
                      num4=Convert.ToInt32(num3); 
                      intlist.Add(num4);
                      freqlist.Add(-1);
                     }
                      catch (Exception) {
                    Console.WriteLine("Enter Numbers Only");
                    num2 -=1;
                    goto Elements;
                }
                     
                }*/
                Console.WriteLine("\nEnter the elements:");
                for (int i=0;i<num2;i++)
                {
                    intlist.Add(Convert.ToInt32(Console.ReadLine()));
                    freqlist.Add(-1);
                }
                  Console.WriteLine("\nOriginal List: ");
                foreach(int i in intlist)
                {
                    Console.Write(" "+i);
                } 
                    Console.WriteLine();

                 intlist.Sort();
                Console.WriteLine("\nSorted List: ");
                foreach(int i in intlist)
                {
                    Console.Write(" "+i);
                }
                Console.WriteLine("\n\nFREQUENCY: ");

                 for(int i=0; i<num2; i++)
                {
                    count = 1;
                    for(int j=i+1; j<num2; j++)
                    {
                        if(intlist[i]==intlist[j])
                        {
                          count++;
                            freqlist[j] = 0;
                        }
                    }

                    if(freqlist[i]!=0)
                    {
                        freqlist[i] = count;
                    }
                }
             for(int i=0; i<num2; i++)
                {
                    if(freqlist[i]!=0)
                    {
                        Console.Write("Frequency of {0} is {1}.\n", intlist[i], freqlist[i]);
                    }

                }
            }
            else if(choice==2)
            {
                Console.WriteLine("\nHow many elements in String List?");
                int num=Convert.ToInt32(Console.ReadLine());
                List <char> stringlist=new List<char>();
                List <int> freqlist=new List<int>();
                Console.WriteLine("\nEnter the elements:");
                for (int i=0;i<num;i++)
                {
                    stringlist.Add(Convert.ToChar(Console.ReadLine()));
                    freqlist.Add(-1);
                }
                  Console.WriteLine("\nOriginal List: ");
                foreach(char i in stringlist)
                {
                    Console.Write(" "+i);
                } 
                    Console.WriteLine();

                 stringlist.Sort();
                Console.WriteLine("\nSorted List: ");
                foreach(char i in stringlist)
                {
                    Console.Write(" "+i);
                }
                Console.WriteLine("\n\nFREQUENCY: ");

                 for(int i=0; i<num; i++)
                {
                    count = 1;
                    for(int j=i+1; j<num; j++)
                    {
                        if(stringlist[i]==stringlist[j])
                        {
                          count++;
                            freqlist[j] = 0;
                        }
                    }

                    if(freqlist[i]!=0)
                    {
                        freqlist[i] = count;
                    }
                }
             for(int i=0; i<num; i++)
                {
                    if(freqlist[i]!=0)
                    {
                        Console.Write("Frequency of {0} is {1}.\n", stringlist[i], freqlist[i]);
                    }

                }
            }
            else
            {
                Console.WriteLine("--------------\nERROR\n--------------\n 'Please input from given choice,'");
                goto Listing;
            }
        }
        }
    }