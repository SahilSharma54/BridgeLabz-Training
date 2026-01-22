

/*

AmbulanceRoute – Emergency Patient Navigation (Circular Linked
List)
Story: In a hospital, there are multiple buildings connected in a circular fashion:
Emergency → Radiology → Surgery → ICU → Emergency.
When an ambulance is bringing in patients, it follows a Circular Linked List to decide the
nearest available unit for emergency treatment.
Requirements:
● Each node represents a hospital unit.
● Rotate through units until an available one is found.
● Simulate patient redirection in a circular path.
● Remove a unit if it's under maintenance.

*/


using System;

// ABSTRACTION
// Interface for ambulance navigation
interface IAmbulanceRoute
{
    void AddUnit(string unitName);
    void FindAvailableUnit();
    void RemoveUnit(string unitName);
    void DisplayUnits();
}


//ENCAPSULATION
// Node class for Circular Linked List
class HospitalUnit
{
    public string UnitName;
    public bool IsAvailable;
    public HospitalUnit Next;

    public HospitalUnit(string name)
    {
        UnitName = name;
        IsAvailable = true;   // Unit is available by default
        Next = null;
    }
}


//INHERITANCE + POLYMORPHISM
// Route manager class
class AmbulanceRoute : IAmbulanceRoute
{
    private HospitalUnit head = null;

    // Add unit to circular list
    public void AddUnit(string unitName)
    {
        HospitalUnit newUnit = new HospitalUnit(unitName);

        if (head == null)
        {
            head = newUnit;
            newUnit.Next = head;
        }
        else
        {
            HospitalUnit temp = head;
            while (temp.Next != head)
                temp = temp.Next;

            temp.Next = newUnit;
            newUnit.Next = head;
        }

        Console.WriteLine(unitName + " unit added.");
    }

    // Rotate through units to find available one
    public void FindAvailableUnit()
    {
        if (head == null)
        {
            Console.WriteLine("No hospital units available.");
            return;
        }

        HospitalUnit temp = head;
        bool found = false;

        do
        {
            if (temp.IsAvailable)
            {
                Console.WriteLine("Redirect patient to: " + temp.UnitName);
                found = true;
                break;
            }
            temp = temp.Next;

        } while (temp != head);

        if (!found)
            Console.WriteLine("No available unit found!");
    }

    // Remove unit if under maintenance
    public void RemoveUnit(string unitName)
    {
        if (head == null)
        {
            Console.WriteLine("No units to remove.");
            return;
        }

        HospitalUnit curr = head;
        HospitalUnit prev = null;

        do
        {
            if (curr.UnitName == unitName)
            {
                if (prev != null)
                    prev.Next = curr.Next;

                // If removing head
                if (curr == head)
                {
                    HospitalUnit temp = head;
                    while (temp.Next != head)
                        temp = temp.Next;

                    head = curr.Next;
                    temp.Next = head;
                }

                Console.WriteLine(unitName + " removed (Under Maintenance).");
                return;
            }

            prev = curr;
            curr = curr.Next;

        } while (curr != head);

        Console.WriteLine("Unit not found.");
    }

    // Display all units
    public void DisplayUnits()
    {
        if (head == null)
        {
            Console.WriteLine("No hospital units available.");
            return;
        }

        HospitalUnit temp = head;
        Console.WriteLine("\nHospital Units (Circular Route):");

        do
        {
            Console.WriteLine("- " + temp.UnitName);
            temp = temp.Next;
        } while (temp != head);
    }
}


// Main application
class AmbulanceRouteApp
{
    static void Main()
    {
        AmbulanceRoute route = new AmbulanceRoute();
        int choice;

        do
        {
            Console.WriteLine("\n===== AmbulanceRoute – Emergency Navigation =====");
            Console.WriteLine("1. Add Hospital Unit");
            Console.WriteLine("2. Find Nearest Available Unit");
            Console.WriteLine("3. Remove Unit (Maintenance)");
            Console.WriteLine("4. Display Units");
            Console.WriteLine("5. Exit");
            Console.Write("Enter choice: ");
            choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Console.Write("Enter unit name: ");
                    route.AddUnit(Console.ReadLine());
                    break;

                case 2:
                    route.FindAvailableUnit();
                    break;

                case 3:
                    Console.Write("Enter unit name to remove: ");
                    route.RemoveUnit(Console.ReadLine());
                    break;

                case 4:
                    route.DisplayUnits();
                    break;

                case 5:
                    Console.WriteLine("Exiting Program..");
                    break;

                default:
                    Console.WriteLine("Invalid choice!");
                    break;
            }

        } while (choice != 5);
    }
}
