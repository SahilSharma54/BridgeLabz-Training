
/*

Goal: Design a Bird Sanctuary system using Inheritance and Polymorphism.
Scenario: EcoWing Wildlife Conservation Center needs to track birds.● Attributes: defined in base class Bird.
● Interfaces: IFlyable (method Fly()), ISwimmable (method Swim()).
● Derived Classes: Eagle, Sparrow (implement IFlyable), Duck, Penguin (implement
ISwimmable), Seagull (implements both).
●Use Array Concept
● Polymorphism: Iterate through list, check interface type (is IFlyable), and call
methods.

*/



using System;

interface IFlyable{
	
    void Fly();
}

interface ISwimmable{
	
    void Swim();
}


class Bird{
	
    public string Name;

    public Bird(string name){
		
        Name = name;
    }

    public void Display(){
		
        Console.WriteLine("Bird: " + Name);
    }
}


class Eagle:Bird,IFlyable{
	
    public Eagle(string name) : base(name) { }

    public void Fly(){
		
        Console.WriteLine(Name + " is flying high.");
    }
}

class Sparrow:Bird,IFlyable{
	
    public Sparrow(string name) : base(name) { }

    public void Fly(){
		
        Console.WriteLine(Name + " is flying.");
    }
}

class Duck:Bird,ISwimmable{
	
    public Duck(string name) : base(name) { }

    public void Swim(){
		
        Console.WriteLine(Name + " is swimming.");
    }
}

class Penguin:Bird,ISwimmable{
	
    public Penguin(string name) : base(name) { }

    public void Swim(){
		
        Console.WriteLine(Name + " is swimming fast.");
    }
}

class Seagull:Bird,IFlyable,ISwimmable{
	
    public Seagull(string name) : base(name) { }

    public void Fly(){
		
        Console.WriteLine(Name + " is flying near sea.");
    }

    public void Swim(){
		
        Console.WriteLine(Name + " is swimming in sea.");
    }
}


class Program{
	
    static void Main(){
		
        
        Bird[] birds = new Bird[5];

        birds[0] = new Eagle("Eagle");
        birds[1] = new Sparrow("Sparrow");
        birds[2] = new Duck("Duck");
        birds[3] = new Penguin("Penguin");
        birds[4] = new Seagull("Seagull");

        // Polymorphic behavior
        foreach (Bird b in birds)
        {
            b.Display();

            if (b is IFlyable)
            {
                ((IFlyable)b).Fly();
            }

            if (b is ISwimmable)
            {
                ((ISwimmable)b).Swim();
            }

            Console.WriteLine();
        }
    }
}
