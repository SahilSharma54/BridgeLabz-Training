using System;

class Person{
	
    string name;
    int age;

    // Normal constructor
    public Person(string n, int a){
		
        name = n;
        age = a;
    }

    // Copy constructor
    public Person(Person p){
		
        name = p.name;
        age = p.age;
    }

    public void Display(){
		
        Console.WriteLine("Name: " + name);
        Console.WriteLine("Age: " + age);
    }
}

class Program{
	
    static void Main(){
		
        Person p1 = new Person("Rahul", 21);
        Person p2 = new Person(p1);

        p2.Display();
    }
}
