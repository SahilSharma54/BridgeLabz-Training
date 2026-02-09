class Menu
{
    PatientUtility patient = new PatientUtility();
    DoctorUtility doctor = new DoctorUtility();
    AppointmentUtility appointment = new AppointmentUtility();
    VisitUtility visit = new VisitUtility();
    PrescriptionUtility prescription = new PrescriptionUtility();
    BillingUtility billing = new BillingUtility();
    PaymentUtility payment = new PaymentUtility();

    public void ShowMenu()
    {
        while (true)
        {
            Console.WriteLine("\n--- Health Clinic Menu ---");
            Console.WriteLine("1. Register Patient");
            Console.WriteLine("2. Search Patient");
            Console.WriteLine("3. Add Doctor");
            Console.WriteLine("4. Book Appointment");
            Console.WriteLine("5. Record Visit");
            Console.WriteLine("6. Add Prescription");
            Console.WriteLine("7. Generate Bill");
            Console.WriteLine("8. View Outstanding Bills");
            Console.WriteLine("9. Record Payment");
            Console.WriteLine("10. Exit");

            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1: patient.RegisterPatient(); break;
                case 2: patient.SearchPatient(); break;
                case 3: doctor.AddDoctor(); break;
                case 4: appointment.BookAppointment(); break;
                case 5: visit.RecordVisit(); break;
                case 6: prescription.AddPrescription(); break;
                case 7: billing.GenerateBill(); break;
                case 8: billing.ViewOutstandingBills(); break;
                case 9: payment.RecordPayment(); break;
                case 10: return;
                default: Console.WriteLine("Invalid choice"); break;
            }
        }
    }
}
