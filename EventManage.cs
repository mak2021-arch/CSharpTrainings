using System;
namespace C_
{
    class Manage
    {

        static void Main(String[] args)
        {
            Console.WriteLine("Welcome to MAK Organisers!");
            Console.WriteLine("Please select the type of event");
            Console.WriteLine("1. Birthday \n2. Marriage \n3. Anniversary \n4. Engagement \n5. Reception");
            int eventChoice= Convert.ToInt32(Console.ReadLine());
            /*Manage obj = new Manage();
            obj.Guest = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(obj.Guest);*/
            switch (eventChoice)
            {
                case 1:
                Console.WriteLine("You Havse Selected 'Birthday' for your event");
                Birthday birthday = new Birthday();
                break;
                
            }
        }
    }
    class Party
    {
        private int _guest;
        private int _decor;
        private int _shift;
        private string _date;
        private string _venue;

        public int Guest
        {
         get { return _guest;}
            set { _guest = value;}
        }
        public int Decor 
        {
            get { return _decor;}
                set { _decor = value;}
        }
        public int Shift
        {
          get { return _shift;}
                set {_shift = value;}
        }
        public String Date
        {
            get { return _date;}
                set {_date = value;}
        }
        public String Venue
        {
            get { return _venue; }
                set {_venue = value;}
        }
     }

    class Birthday : Party
    {
        public Birthday()
        {
        Console.Write("Enter number of Guests");
        Birthday obj = new Birthday();
        obj.Guest = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine(obj.Guest);
        }
    } 
    }


