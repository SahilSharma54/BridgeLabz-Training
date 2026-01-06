
/*

Hospital Patient Management System
● Concepts: Patient, Doctor, Bill classes.
● OOP: Encapsulation (Properties), Abstraction (Interface IPayable), Inheritance
(InPatient, OutPatient : Patient), Polymorphism (DisplayInfo).

*/



using System;

// Interface for payment (Abstraction)
interface IPayable
{
    double CalculateBill();
}

// Base class
class Patient
{
    // Encapsulated properties
    public int PatientId { get; set; }
    public string Name { get; set; }

    // Virtual method for polymorphism
    public virtual void DisplayInfo()
    {
        Console.WriteLine("Patient ID: " + PatientId);
        Console.WriteLine("Name: " + Name);
    }
}

// InPatient class
class InPatient : Patient, IPayable
{
    public int NumberOfDays;
    public double DailyCharge;

    public double CalculateBill()
    {
        return NumberOfDays * DailyCharge;
    }

    public override void DisplayInfo()
    {
        Console.WriteLine("In-Patient Details:");
        base.DisplayInfo();
        Console.WriteLine("Days Admitted: " + NumberOfDays);
        Console.WriteLine("Total Bill: " + CalculateBill());
    }
}

// OutPatient class
class OutPatient : Patient, IPayable
{
    public double ConsultationFee;

    public double CalculateBill()
    {
        return ConsultationFee;
    }

    public override void DisplayInfo()
    {
        Console.WriteLine("Out-Patient Details:");
        base.DisplayInfo();
        Console.WriteLine("Consultation Fee: " + CalculateBill());
    }
}

class HospitalProgram
{
    static void Main()
    {
        // In-patient object
        Patient p1 = new InPatient
        {
            PatientId = 101,
            Name = "Sahil 1",
            NumberOfDays = 5,
            DailyCharge = 2000
        };

        // Out-patient object
        Patient p2 = new OutPatient
        {
            PatientId = 102,
            Name = "Sahil 2",
            ConsultationFee = 500
        };

        // Polymorphism
        p1.DisplayInfo();
        Console.WriteLine();

        p2.DisplayInfo();
    }
}
