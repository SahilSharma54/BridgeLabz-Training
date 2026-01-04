using System;

class HotelBooking{
	
    string guestName;
    string roomType;
    int nights;

    // Default constructor
    public HotelBooking(){
		
        guestName = "Guest";
        roomType = "Standard";
        nights = 1;
    }

    // Parameterized constructor
    public HotelBooking(string g, string r, int n){
		
        guestName = g;
        roomType = r;
        nights = n;
    }

    // Copy constructor
    public HotelBooking(HotelBooking h){
		
        guestName = h.guestName;
        roomType = h.roomType;
        nights = h.nights;
    }

    public void Display(){
		
        Console.WriteLine("Guest: " + guestName);
        Console.WriteLine("Room Type: " + roomType);
        Console.WriteLine("Nights: " + nights);
    }
}

class Program{
	
    static void Main(){
		
        HotelBooking h1 = new HotelBooking("Amit", "Deluxe", 3);
        HotelBooking h2 = new HotelBooking(h1);

        h2.Display();
    }
}
