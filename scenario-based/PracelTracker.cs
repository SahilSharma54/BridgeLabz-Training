

/*

ParcelTracker – Delivery Chain Management (Singly Linked List)
Story: A courier company tracks parcels through stages like Packed → Shipped → In Transit →
Delivered. Each stage is a node in a Singly Linked List.
Requirements:
● Forward tracking through stages.
● Add custom intermediate checkpoints.
● Handle lost/missing parcels (null pointers).

*/



using System;

// ABSTRACTION 
interface IParcelTracker
{
    void AddStage(string stage);
    void AddCheckpoint(string afterStage, string newStage);
    void TrackParcel();
    void MarkParcelLost();
}

// NODE CLASS 
class StageNode
{
    public string StageName;
    public StageNode Next;
}

// INHERITANCE 
// Base class
class BaseTracker
{
    protected StageNode head;
}

// POLYMORPHISM 
// Derived class implementing interface
class ParcelTracker : BaseTracker, IParcelTracker
{
    // ENCAPSULATION 
    // head is protected and accessed only via methods

    public void AddStage(string stage)
    {
        StageNode newNode = new StageNode();
        newNode.StageName = stage;
        newNode.Next = null;

        if (head == null)
        {
            head = newNode;
            return;
        }

        StageNode temp = head;
        while (temp.Next != null)
        {
            temp = temp.Next;
        }

        temp.Next = newNode;
    }

    public void AddCheckpoint(string afterStage, string newStage)
    {
        if (head == null)
        {
            Console.WriteLine("Parcel missing. No stages found.");
            return;
        }

        StageNode temp = head;
        while (temp != null && temp.StageName != afterStage)
        {
            temp = temp.Next;
        }

        if (temp == null)
        {
            Console.WriteLine("Stage not found.");
            return;
        }

        StageNode newNode = new StageNode();
        newNode.StageName = newStage;
        newNode.Next = temp.Next;
        temp.Next = newNode;

        Console.WriteLine("Checkpoint added.");
    }

    // Overridden method → Polymorphism
    public virtual void TrackParcel()
    {
        if (head == null)
        {
            Console.WriteLine("Parcel is lost.");
            return;
        }

        StageNode temp = head;
        Console.WriteLine("Parcel Delivery Path:");

        while (temp != null)
        {
            Console.Write(temp.StageName + " -> ");
            temp = temp.Next;
        }

        Console.WriteLine("END");
    }

    public void MarkParcelLost()
    {
        head = null;
        Console.WriteLine("Parcel marked as lost.");
    }
}

// MAIN CLASS 
class Program
{
    static void Main(string[] args)
    {
        // Polymorphism: interface reference
        IParcelTracker tracker = new ParcelTracker();
        int choice;

        do
        {
            Console.WriteLine("--- Parcel Tracker Menu ---");
            Console.WriteLine("1. Add Stage");
            Console.WriteLine("2. Add Intermediate Checkpoint");
            Console.WriteLine("3. Track Parcel");
            Console.WriteLine("4. Mark Parcel Lost");
            Console.WriteLine("5. Exit");
            Console.Write("Enter choice: ");

            choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Console.Write("Enter stage name: ");
                    tracker.AddStage(Console.ReadLine());
                    break;

                case 2:
                    Console.Write("Enter existing stage: ");
                    string afterStage = Console.ReadLine();

                    Console.Write("Enter new checkpoint: ");
                    string newStage = Console.ReadLine();

                    tracker.AddCheckpoint(afterStage, newStage);
                    break;

                case 3:
                    tracker.TrackParcel();
                    break;

                case 4:
                    tracker.MarkParcelLost();
                    break;

                case 5:
                    Console.WriteLine("Program exited.");
                    break;

                default:
                    Console.WriteLine("Invalid choice.");
                    break;
            }

        } while (choice != 5);
    }
}
