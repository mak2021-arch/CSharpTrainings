using System;
using System.IO;

namespace C
{
    class UsingFile
    {
        static void Main()
        {
            string filename = @"mytext.txt";
            string[] Arlines;
            int n;
        Console.WriteLine("Read Lines from file");

      using (FileStream fs = File.Create(filename))
        Console.WriteLine("Input number of lines to write:");
        n=Convert.ToInt32(Console.ReadLine());
        Arlines=new string[n];
        Console.WriteLine("Input {0} strings :\n",n);
        for(int i =0;i<n;i++) {
            Console.WriteLine("Input Line {0}: ",i+1);
            Arlines[i]=Console.ReadLine();
        }
        System.IO.File.WriteAllLines(filename, Arlines);
        Console.Write("\n Input the number of lines to display:");
        int l= Convert.ToInt32(Console.ReadLine());
        int ln=l;
        if(l>=1 && l<=n) {
            Console.Write("\n The contents of {0} lines of {1} are:\n",l,filename);
           if(File.Exists(filename)) {
                for(int i=n-l;i<n;i++) {
                    String[] lines = File.ReadAllLines(filename);
                    Console.WriteLine("\nThe last no {0} line of is: {1} \n",ln,lines[i]);
                    ln--;      
                }
            }
        }
				else {
				  Console.WriteLine(" Please input the correct line no.");
				}

            Console.WriteLine();  
        }
        }
    }