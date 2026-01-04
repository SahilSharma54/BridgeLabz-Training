using System;

class Patient{
	
    // static variable
    public static string HospitalName = "City Care Hospital";

    // readonly variable
    public readonly int PatientID;

    // instance variables
    public string Name;
    public int Age;
    public string Ailment;

    // static counter
    static int totalPatients = 0;

    // constructor using this
    public Patient(int id, string name, int age, string ailment){
		
        this.PatientID = id;
        this.Name = name;
        this.Age = age;
        this.Ailment = ailment;
        totalPatients++;
    }

    // static method
    public static void GetTotalPatients(){
		
        Console.WriteLine("Total Patients: " + totalPatients);
    }

    // display method
    public void DisplayDetails(){
		
        Console.WriteLine("Hospital Name: " + HospitalName);
        Console.WriteLine("Patient ID: " + PatientID);
        Console.WriteLine("Name: " + Name);
        Console.WriteLine("Age: " + Age);
        Console.WriteLine("Ailment: " + Ailment);
    }
}

class Program{
	
    static void Main(){
		
        Patient p1 = new Patient(101, "Sahil", 25, "Fever");

        // is operator
        if (p1 is Patient){
			
            p1.DisplayDetails();
        }

        Patient.GetTotalPatients();
    }
}
