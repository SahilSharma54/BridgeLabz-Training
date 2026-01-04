using System;

class Circle{
	
    double radius;

    // Default constructor
    public Circle() : this(1) { }

    // Parameterized constructor
    public Circle(double r){
		
        radius = r;
    }

    public void Display(){
		
        double area = 3.14 * radius * radius;
        double circumference = 2 * 3.14 * radius;

        Console.WriteLine("Radius: " + radius);
        Console.WriteLine("Area: " + area);
        Console.WriteLine("Circumference: " + circumference);
    }
}

class Program
{
    static void Main()
    {
        Circle c = new Circle(5);
        c.Display();
    }
}
