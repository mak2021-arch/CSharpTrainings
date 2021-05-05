using System;
namespace C_
{
    //Main Class to inherit Var class for I/O
    class Manage : Var
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
                Var v = new Var();
                v.MyGuest();
                Birthday b = new Birthday();
                b.MyBirthday();
                v.MyDecor();
                v.MyShift();
                v.MyDate();
                v.MyVenue();

                break;
                
            }
        }
    }
    // Parent Class to Inherit Values
    class Party
    {
        private int _guest;
        private int _decor;
        private int _shift;
        private string _date;
        private int _venue;

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
        public int Venue
        {
            get { return _venue;}
                set {_venue = value;}
        }
     }

    class Birthday : Party
    {
        public void MyBirthday()
        {
            Console.WriteLine("Please Select the Catering Option: \n1.'Classic'  --Rs. 200 per plate\n2. 'Regular' --Rs. 400 per plate\n3. 'Exquisite' --Rs. 600 per person ");
            int cat = Convert.ToInt32(Console.ReadLine());
            switch (cat)
            {
                case 1:
                
                break;
            }

        }
    }
    // Class Var for I/O operation
     class Var : Party
     {
         public void MyGuest()
        {
            Console.WriteLine("Enter the number of Guest \n'Due to Covid Protocols There is a Minimum limit of 40 guests and maximum of 100 Guests'");
            Var obj = new Var();
            int noOfGuest = Convert.ToInt32(Console.ReadLine());
            obj.Guest = noOfGuest;
         //   if (!Int32.IsNumber)
          //     Console.WriteLine("Not an integer");
        }
        public void MyDecor()
        {
            Decoration:
            Console.WriteLine("Choose the Decoration Type \n1. 'Silver' --Rs. 5000\n2. 'Gold' --Rs. 8000\n3. 'Platinum' --Rs. 10,000/n");
            int decorType = Convert.ToInt32(Console.ReadLine());
            var obj = new Var();
            obj.Decor = decorType;
            switch (decorType)
            {
                case 1:
                Console.WriteLine("You have Chosen 'Silver Package' Charges is Rs. 5000/-/n");
                break;
                case 2:
                Console.WriteLine("You have Chosen 'Gold Package' Charges is Rs. 8000/-/n");
                break;
                case 3:
                Console.WriteLine("You have Chosen 'Platinum Package' Charges is Rs.10,000/-/n");
                break;
                default:
                Console.WriteLine("Enter a Valid Input. Try Again");
                goto Decoration;
            }
        }
        public void MyShift()
        {
            Shift:
            Console.WriteLine("Choose the Shift \n1. 'Morning' --Rs. 2000 \n2. 'Evening'  --Rs. 4000\n3. 'Night' --Rs.6000\n");
            int shiftType = Convert.ToInt32(Console.ReadLine());
            var obj = new Var();
            obj.Shift = shiftType;
            switch (shiftType)
            {
                case 1:
                Console.WriteLine("You have Chosen 'Morning Shift' Booking Charges is Rs. 2000/-\n");
                break;
                case 2:
                Console.WriteLine("You have Chosen 'Evening Shift' Booking Charges is Rs. 4000/-\n");
                break;
                case 3:
                Console.WriteLine("You have Chosen 'Night Shift' Booking Charges is Rs. 6000/-\n");
                break;
                default:
                Console.WriteLine("Enter a Valid Input. Try Again");
                goto Shift;
            }
        }
        public void MyDate()
        {
            Console.WriteLine("Please Enter the Date:");
            string dateType = Console.ReadLine();
            var obj = new Var();
            obj.Date = dateType;
        }

        public void MyVenue()
        {
            Venue:
            Console.WriteLine("Select the Venue: \n1. Beach Side \n2. Open Garden \n3. Banquet Hall \n4. Paradise Pent House\n");
            int venueType = Convert.ToInt32(Console.ReadLine());
            var obj = new Var();
            obj.Venue = venueType;
            switch (venueType)
            {
                case 1:
                Console.WriteLine("You have selected 'Beach Side' venue ");
                break;
                case 2:
                Console.WriteLine("You have selected 'Open Garden' venue");
                break;
                case 3:
                Console.WriteLine("You have selected 'Banquet Hall' venue");
                break;
                case 4:
                Console.WriteLine("You have selected 'Paradise Pent House' venue");
                break;
                default:
                Console.WriteLine("Enter a Valid Input. Try Again");
                goto Venue;
            }
        }

    }
}


