using System;
namespace C_
{
    //Main Class to inherit Var class for I/O
    class Manage : Var
    {

        static void Main(String[] args)
        {
            Manage:
            Var v = new Var();
            UserSelection u = new UserSelection();
            Console.WriteLine("Welcome to MAK Organisers!");
            Console.WriteLine("Please select the type of event");
            Console.WriteLine("1. Birthday \n2. Marriage \n3. Anniversary \n4. Engagement \n5. Reception");
            int eventChoice;
            string input= Console.ReadLine();
            try {
                eventChoice = Convert.ToInt32(input);
            }
            catch (Exception) {
                Console.WriteLine("---------------- \nERROR!\n---------------- \nPlease input from selected choices!");
                goto Manage;
            }

            switch (eventChoice)
            {
                case 1:
                Console.WriteLine("You Have Selected 'Birthday' for your event\n");
                v.MyGuest();
                v.MyCatering();
                v.MyDecor();
                v.MyShift();
                v.MyDate();
                u.selectedVenue();
                //v.MyVenue();
                v.Confirmation();
                 break;

                 case 2:
                Console.WriteLine("You Have Selected 'Marriage' for your event\n");
                v.MyGuest();
                v.MyCatering();
                v.MyDecor();
                v.MyShift();
                v.MyDate();
                v.MyVenue();
                v.Confirmation();
                 break;

                 case 3:
                Console.WriteLine("You Have Selected 'Anniversary' for your event\n");
                v.MyGuest();
                v.MyCatering();
                v.MyDecor();
                v.MyShift();
                v.MyDate();
                v.MyVenue();
                v.Confirmation();
                 break;

                 case 4:
                Console.WriteLine("You Have Selected 'Engagement' for your event\n");
                v.MyGuest();
                v.MyCatering();
                v.MyDecor();
                v.MyShift();
                v.MyDate();
                v.MyVenue();
                v.Confirmation();
                 break;

                  case 5:
                Console.WriteLine("You Have Selected 'Reception' for your event\n");
                v.MyGuest();
                v.MyCatering();
                v.MyDecor();
                v.MyShift();
                v.MyDate();
                v.MyVenue();
                v.Confirmation();
                 break;
                 
                   default:
                   Console.WriteLine("---------------- \nERROR!\n---------------- \nPlease input from selected choices!");
                   goto Manage;
                
            }
        }
    }
    // Class Encapsulation
    class Party
    {
        private int _guest;
        private int _decor;
        private string _shift;
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
        public string Shift
        {
          get { return _shift;}
                set {_shift = value;}
        }
        public string PartyDate
        {
            get { return _date;}
                set {_date = value;}
        }
        public string Venue
        {
            get { return _venue;}
                set {_venue = value;}
        }
     }

    

   
    // Class Var for I/O operation
     class Var : Party
     {
         public void MyGuest()
        {   
            
            Console.WriteLine("'Enter the number of Guest' \n'Due to Covid Protocols there is a Minimum limit of 40 guests and maximum of 100 Guests'");           
            int noOfGuest = Convert.ToInt32(Console.ReadLine());
            if (noOfGuest<40 || noOfGuest>100)
            {
             Console.WriteLine("Enter value in the given range");
                 MyGuest();
                
            }
            else{
            Guest = noOfGuest;
            Console.WriteLine("Gathering of:"+Guest);
            Console.WriteLine();
                 }
  
        }
        public void MyCatering()
        {
            Catering:
            Console.WriteLine("Please Select the Catering Option: \n1.'Classic'  --Rs. 200 per plate\n2. 'Regular' --Rs. 400 per plate\n3. 'Exquisite' --Rs. 600 per person\n ");
            int cateringSelection;
            int cc1;
            string input= Console.ReadLine();
            try {
                cateringSelection = Convert.ToInt32(input);
            }
            catch (Exception)
            {
                Console.WriteLine("---------------- \nERROR!\n---------------- \nPlease input from selected choices!");
            goto Catering;
            }
            switch (cateringSelection)
            {
                case 1:
                Console.WriteLine("You have selected 'Classic' for Catering\n");
                cc1 = 200*Guest; 
                Console.WriteLine("The Catering cost for " +Guest+ " people will be: Rs." +cc1 );
                break;

                case 2:
                Console.WriteLine("You have selected 'Regular' for Catering\n");
                 cc1 = 400*Guest; 
                Console.WriteLine("The Catering cost for " +Guest+ " people will be: Rs." +cc1 );
                break;

                case 3:
                Console.WriteLine("You have selected 'Exquiste' for Catering\n");
                cc1 = 600*Guest; 
                Console.WriteLine("The Catering cost for " +Guest+ " people will be: Rs." +cc1 );
                break;

                default:
                   Console.WriteLine("---------------- \nERROR!\n---------------- \nPlease input from selected choices!");
                   goto Catering ;
            }

        }
       
        public void MyDecor()
        {
            Decoration:
            Console.WriteLine("\nChoose the Decoration Type \n1. 'Silver' --Rs. 5000\n2. 'Gold' --Rs. 8000\n3. 'Platinum' --Rs. 10,000\n");
            int decorType = Convert.ToInt32(Console.ReadLine());
            Var obj = new Var();
            obj.Decor = decorType;
            switch (decorType)
            {
                case 1:
                Console.WriteLine("You have Chosen 'Silver Package' Charges is Rs. 5000/-\n");
                break;

                case 2:
                Console.WriteLine("You have Chosen 'Gold Package' Charges is Rs. 8000/-\n");
                break;

                case 3:
                Console.WriteLine("You have Chosen 'Platinum Package' Charges is Rs.10,000/-\n");
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
            PartyDate = dateType;
        }

        public void MyVenue()
        {
            Venue:
            Console.WriteLine("Select the Venue: \n1. Beach Side \n2. Open Garden \n3. Banquet Hall \n4. Paradise Pent House\n");
            int venueType = Convert.ToInt32(Console.ReadLine());
            
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

        public void Confirmation(){
            
                Console.WriteLine("\nYou have registered your party on " + PartyDate + " for " + Guest + " guests. And the venue is " + Venue + " in " + Shift + ".\n Do you wish to Continue?");
               string agree = Console.ReadLine();

               if(agree == "y" || agree == "yes" || agree == "Yes" || agree == "YES"){
                   Console.WriteLine("Your booking has been confirmed!!\n Thank you for choosing us.");
                   Console.ReadKey();
               }
               else if(agree == "n" || agree == "no" || agree == "No" || agree == "NO"){
                   Console.WriteLine("You cancelled the selection.\n Thank you, visit again..");
                   Console.ReadKey();
               }
        }

    }


    abstract class Venue{
public abstract void selectedVenue();
    }
    
    class UserSelection : Venue{
        public override void selectedVenue()
        {
           Venue:
            Console.WriteLine("Select the Venue: \n1. Beach Side \n2. Open Garden \n3. Banquet Hall \n4. Paradise Pent House\n");
            int venueType = Convert.ToInt32(Console.ReadLine());
            
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
    


