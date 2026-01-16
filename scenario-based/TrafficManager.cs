
/*

TrafficManager – Roundabout Vehicle Flow Story: A smart city roundabout allows vehicles to enter and exit dynamically. Each vehicle is a node in a Circular Linked List. A Queue manages vehicles waiting to enter.
Requirements:
● Add or remove cars in a circular path.
● Queue overflow/underflow handling.
● Print state of roundabout at any time.

*/



using System;

// ABSTRACTION 
// Interface hides traffic operations
interface ITrafficManager
{
    void AddToQueue();
    void EnterRoundabout();
    void ExitRoundabout();
    void DisplayState();
}

// BASE CLASS 
class Vehicle
{
    protected string vehicleNumber;

    public Vehicle(string number)
    {
        vehicleNumber = number;
    }

    // Polymorphism
    public virtual void Display()
    {
        Console.Write(vehicleNumber + " ");
    }

    public string GetNumber()
    {
        return vehicleNumber;
    }
}

// INHERITANCE 
class Car : Vehicle
{
    public Car(string number) : base(number)
    {
    }

    // Polymorphism
    public override void Display()
    {
        Console.Write("[Car: " + vehicleNumber + "] ");
    }
}

// NODE (CIRCULAR LINKED LIST) 
class VehicleNode
{
    public Vehicle data;
    public VehicleNode next;

    public VehicleNode(Vehicle vehicle)
    {
        data = vehicle;
        next = null;
    }
}

// CIRCULAR LINKED LIST 
class Roundabout
{
    private VehicleNode tail; // Encapsulation

    // Add vehicle
    public void AddVehicle(Vehicle vehicle)
    {
        VehicleNode newNode = new VehicleNode(vehicle);

        if (tail == null)
        {
            tail = newNode;
            tail.next = tail;
            return;
        }

        newNode.next = tail.next;
        tail.next = newNode;
        tail = newNode;
    }

    // Remove vehicle
    public void RemoveVehicle()
    {
        if (tail == null)
        {
            Console.WriteLine("Roundabout is empty.");
            return;
        }

        if (tail.next == tail)
        {
            Console.WriteLine("Vehicle exited: " + tail.data.GetNumber());
            tail = null;
            return;
        }

        VehicleNode head = tail.next;
        Console.WriteLine("Vehicle exited: " + head.data.GetNumber());
        tail.next = head.next;
    }

    // Display roundabout
    public void Display()
    {
        if (tail == null)
        {
            Console.WriteLine("Roundabout is empty.");
            return;
        }

        VehicleNode temp = tail.next;
        Console.Write("Roundabout: ");

        do
        {
            temp.data.Display(); // Polymorphism
            temp = temp.next;
        }
        while (temp != tail.next);

        Console.WriteLine();
    }

    public bool IsEmpty()
    {
        return tail == null;
    }
}

// QUEUE 
class VehicleQueue
{
    private Vehicle[] queue;
    private int front, rear, size;

    public VehicleQueue(int capacity)
    {
        queue = new Vehicle[capacity];
        front = 0;
        rear = -1;
        size = 0;
    }

    // Enqueue
    public void Enqueue(Vehicle vehicle)
    {
        if (size == queue.Length)
        {
            Console.WriteLine("Queue Overflow!");
            return;
        }

        rear++;
        queue[rear] = vehicle;
        size++;

        Console.WriteLine("Vehicle added to waiting queue.");
    }

    // Dequeue
    public Vehicle Dequeue()
    {
        if (size == 0)
        {
            Console.WriteLine("Queue Underflow!");
            return null;
        }

        Vehicle vehicle = queue[front];
        front++;
        size--;
        return vehicle;
    }

    // Display queue
    public void Display()
    {
        if (size == 0)
        {
            Console.WriteLine("Waiting queue empty.");
            return;
        }

        Console.Write("Waiting Queue: ");
        for (int i = front; i <= rear; i++)
        {
            queue[i].Display(); // Polymorphism
        }
        Console.WriteLine();
    }

    public bool IsEmpty()
    {
        return size == 0;
    }
}

// TRAFFIC MANAGER 
class TrafficManager : ITrafficManager
{
    private Roundabout roundabout = new Roundabout();
    private VehicleQueue queue = new VehicleQueue(5);

    public void AddToQueue()
    {
        Console.Write("Enter Vehicle Number: ");
        string number = Console.ReadLine();

        Vehicle car = new Car(number);
        queue.Enqueue(car);
    }

    public void EnterRoundabout()
    {
        if (!queue.IsEmpty())
        {
            Vehicle vehicle = queue.Dequeue();
            roundabout.AddVehicle(vehicle);
            Console.WriteLine("Vehicle entered roundabout.");
        }
        else
        {
            Console.WriteLine("No vehicles in queue.");
        }
    }

    public void ExitRoundabout()
    {
        roundabout.RemoveVehicle();
    }

    public void DisplayState()
    {
        roundabout.Display();
        queue.Display();
    }
}

// MENU DRIVEN MAIN 
class Program
{
    static void Main(string[] args)
    {
        ITrafficManager manager = new TrafficManager();
        int choice;

        do
        {
            Console.WriteLine("--- Traffic Manager ---");
            Console.WriteLine("1. Add Vehicle to Queue");
            Console.WriteLine("2. Enter Roundabout");
            Console.WriteLine("3. Exit Roundabout");
            Console.WriteLine("4. Display State");
            Console.WriteLine("5. Exit");
            Console.Write("Enter choice: ");

            choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    manager.AddToQueue();
                    break;

                case 2:
                    manager.EnterRoundabout();
                    break;

                case 3:
                    manager.ExitRoundabout();
                    break;

                case 4:
                    manager.DisplayState();
                    break;

                case 5:
                    Console.WriteLine("Exiting system.");
                    break;

                default:
                    Console.WriteLine("Invalid choice.");
                    break;
            }

        } while (choice != 5);
    }
}

