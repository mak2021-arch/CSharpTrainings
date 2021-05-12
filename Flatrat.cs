using System;
namespace Flatrat
{

interface IMessage
{
   void Message();
}

    class RoomInfo : Var
    {

        static void Main(String[] args)
        {
            Console.WriteLine("\n\nWelcome to 'FlatRat' \nA single Console App to find a Flat that suites your need\n\n");
            Var obj = new Var();
            obj.MyLoc();
            obj.MyRoom();
            obj.Myfurn();
            obj.MyName();
        }
    }
class Room
    {
        private int _noofroom;
        private int _furn;
        private string _name;
        private string _loc;
        public int Noofroom
        {
         get { return _noofroom;}
            set { _noofroom = value;}
        }
        public int Furn 
        {
            get { return _furn;}
                set { _furn = value;}
        }
        public string Name
        {
          get { return _name;}
                set {_name = value;}
        }
        public string Loc
        {
            get { return _loc;}
                set {_loc = value;}
        }
     }
       

class Var: Room
{
    public void MyLoc()
    {
        Console.WriteLine("Enter The location of your choice where you want to rent");
        Loc=Console.ReadLine();
        Console.WriteLine("You have entered '{0}' as your location.",Loc);
    }
    public void MyRoom()
    {
        Console.WriteLine("\nEnter the no. of Rooms required");
        int noOfRoom = Convert.ToInt32(Console.ReadLine());
        Noofroom=noOfRoom;
        if (noOfRoom>=1 && noOfRoom<=4) {
            Console.WriteLine("\nYou have selected {0} Room set",Noofroom);
        }

        else {
            Console.WriteLine("Enter a Valid Room set from 1 to 4");
            MyRoom();
        }

    }

    public void Myfurn()
    {
        Console.WriteLine("\nPlease select the type of Room:\n1. Fully Furnished \n2. Semi Furnished \n3. Un furnished");
        int furn = Convert.ToInt32(Console.ReadLine());
        Furn=furn;
        int r;
        switch (Furn)
        {
            case 1:
            Console.WriteLine("You have selected 'Fully Furnished' {0} Room set.",Noofroom);
            r=Noofroom*6000;
            Console.WriteLine("Rent is :{0} for {1}",r, Loc);
            break;

            case 2:
            Console.WriteLine("You have selected 'Semi Furnished' {0} Room set.",Noofroom);
            r=Noofroom*4000;
            Console.WriteLine("Rent is :{0} for {1}",r,Loc);
            break;

            case 3:
            Console.WriteLine("You have selected 'Un Furnished' {0} Room set.",Noofroom);
            r=Noofroom*2500;
            Console.WriteLine("Rent is :{0} for {1}",r,Loc);
            break;
            
            default:
            Console.WriteLine("Please select From Given Options");
            Myfurn();
            break;
        }

    }

    public void MyName()
    {
        Console.Write("Enter your Full name:");
        Name=Console.ReadLine();
    }


}
}