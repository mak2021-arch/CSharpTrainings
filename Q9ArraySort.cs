using System;
namespace C_
{
    class sort
    {
        static void Main(String[] args)
        {
            int [] ar1 = new int[10];
            int [] ar2 = new int[10];
            int [] ar3 = new int[10];
            int j=0,k=0;

             Console.Write("Input 10 elements in the array :\n");
              for(int i=0;i<10;i++)
            {
	         Console.Write("Enter next element: ");
    	     ar1[i] = Convert.ToInt32(Console.ReadLine()); 		  
	        }

        for(int i=0;i<10;i++)
        {
	        if (ar1[i]%2 == 0)
	        {
	            ar2[j] = ar1[i];
	            j++;
	        }
	        else
	        {
	            ar3[k] = ar1[i];
	            k++;
	        }
        }

        Console.Write("\nThe Even elements are : \n");
        for(int i=0;i<j;i++)
        {
	        Console.Write("{0} ",ar2[i]);
        }

        Console.Write("\nThe Odd elements are :\n");
        for(int i=0;i<k;i++)
        {
	        Console.Write("{0} ",ar3[i]);
        }
        Console.Write("\n\n");	
        }
    }
}