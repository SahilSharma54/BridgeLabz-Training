using System;

class Circle{
	
    double radius;

    public void GetRadius(){
		
        Console.Write("Enter radius: ");
        radius = double.Parse(Console.ReadLine());
    }

    public void Calculate(){
		
        double area = 3.14 * radius * radius;
        double circumference = 2 * 3.14 * radius;

        Console.WriteLine("Area of Circle: " + area);
        Console.WriteLine("Circumference of Circle: " + circumference);
    }
}

class Program{
	
    static void Main(string[] args){
		
        Circle c = new Circle();
        c.GetRadius();
        c.Calculate();
    }
}
