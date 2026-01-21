using System;
using System.Collections.Generic;

class InsurancePolicy
{
    public string PolicyNumber;
    public string CoverageType;
    public DateTime ExpiryDate;

    public override string ToString()
    {
        return PolicyNumber + " | " + CoverageType + " | " + ExpiryDate.ToShortDateString();
    }
}

class Program
{
    static void Main()
    {
        HashSet<string> policySet = new HashSet<string>(); // Unique check
        LinkedList<InsurancePolicy> policyOrder = new LinkedList<InsurancePolicy>(); // Maintain insertion order
        SortedDictionary<DateTime, List<InsurancePolicy>> policySorted = new SortedDictionary<DateTime, List<InsurancePolicy>>(); // Sorted by expiry

        int choice;
        do
        {
            Console.WriteLine("\n--- Insurance Policy System ---");
            Console.WriteLine("1. Add Policy");
            Console.WriteLine("2. Show All Policies");
            Console.WriteLine("3. Show Policies Expiring in 30 Days");
            Console.WriteLine("4. Exit");
            Console.Write("Enter choice: ");
            choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Console.Write("Policy Number: ");
                    string number = Console.ReadLine();
                    if (policySet.Contains(number))
                    {
                        Console.WriteLine("Duplicate policy number! Skipped.");
                        break;
                    }

                    Console.Write("Coverage Type: ");
                    string type = Console.ReadLine();

                    Console.Write("Expiry Date (yyyy-mm-dd): ");
                    DateTime expiry = DateTime.Parse(Console.ReadLine());

                    InsurancePolicy policy = new InsurancePolicy
                    {
                        PolicyNumber = number,
                        CoverageType = type,
                        ExpiryDate = expiry
                    };

                    // Add to unique set
                    policySet.Add(number);

                    // Add to insertion order list
                    policyOrder.AddLast(policy);

                    // Add to sorted dictionary
                    if (!policySorted.ContainsKey(expiry))
                        policySorted[expiry] = new List<InsurancePolicy>();
                    policySorted[expiry].Add(policy);

                    Console.WriteLine("Policy added successfully!");
                    break;

                case 2:
                    Console.WriteLine("\nAll Policies (Insertion Order):");
                    foreach (var p in policyOrder)
                        Console.WriteLine(p);
                    break;

                case 3:
                    Console.WriteLine("\nPolicies Expiring in 30 Days:");
                    DateTime now = DateTime.Today;
                    foreach (var kvp in policySorted)
                    {
                        foreach (var p in kvp.Value)
                        {
                            if ((p.ExpiryDate - now).TotalDays <= 30 && (p.ExpiryDate - now).TotalDays >= 0)
                                Console.WriteLine(p);
                        }
                    }
                    break;
            }

        } while (choice != 4);
    }
}
