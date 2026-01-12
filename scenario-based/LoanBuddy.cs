
/*

"LoanBuddy – Loan Approval Automation"
Story: A fintech startup named FinlyTech is launching a product called LoanBuddy, a web and
mobile app that automates personal loan approvals for salaried and self-employed applicants.
LoanBuddy should collect applicant data, verify eligibility, evaluate credit risk, and either
approve or reject the loan based on custom rules. It also calculates monthly EMIs and provides
a personalized repayment plan.
You’re hired as a Java backend developer to design and implement the core loan approval
engine.
Requirements:
● Applicant class: name, creditScore, income, loanAmount.
● LoanApplication class with loan type, term, and interest rate.
● Interface IApprovable with approveLoan() and calculateEMI().
● Use constructors to support different types of loans (personal, home, auto).
● Operators for EMI calculation: P × R × (1+R)^N / ((1+R)^N – 1)
● Encapsulation: keep credit score and internal approval logic private.
● Inheritance: different loan types (HomeLoan, AutoLoan) extending base class.
  ● Polymorphism: EMI calculation logic varies by loan type.
 ● Access modifiers to limit loan status changes to internal processes only.

*/

using System;

// INTERFACE (ABSTRACTION)
interface IApprovable
{
    bool ApproveLoan();
    double CalculateEMI();
}

// APPLICANT CLASS (ENCAPSULATION) 
class Applicant
{
    private string name;
    private int creditScore;
    private double income;
    private double loanAmount;

    // Constructor
    public Applicant(string name, int creditScore, double income, double loanAmount)
    {
        this.name = name;
        this.creditScore = creditScore;
        this.income = income;
        this.loanAmount = loanAmount;
    }

    // Getters and Setters
    public string Name
    {
        get { return name; }
        set { name = value; }
    }

    public int CreditScore
    {
        get { return creditScore; }
        set { creditScore = value; }
    }

    public double Income
    {
        get { return income; }
        set { income = value; }
    }

    public double LoanAmount
    {
        get { return loanAmount; }
        set { loanAmount = value; }
    }
}

// BASE LOAN CLASS 
abstract class LoanApplication : IApprovable
{
    protected Applicant applicant;
    protected int term;                // months
    protected double interestRate;     // annual 

    private string loanStatus;

    public LoanApplication(Applicant applicant, int term, double interestRate)
    {
        this.applicant = applicant;
        this.term = term;
        this.interestRate = interestRate;
        loanStatus = "PENDING";
    }

    // Encapsulated eligibility logic
    protected bool BasicEligibility()
    {
        return applicant.CreditScore >= 650 &&
               applicant.Income >= applicant.LoanAmount / 10;
    }

   
    protected string LoanStatus
    {
        get { return loanStatus; }
        set { loanStatus = value; }
    }

    public string GetLoanStatus()
    {
        return loanStatus;
    }

    public abstract bool ApproveLoan();
    public abstract double CalculateEMI();
}

// HOME LOAN
class HomeLoan : LoanApplication
{
    public HomeLoan(Applicant applicant, int term)
        : base(applicant, term, 7.5) { }

    public override bool ApproveLoan()
    {
        if (BasicEligibility() && applicant.CreditScore >= 700)
        {
            LoanStatus = "APPROVED";
            return true;
        }

        LoanStatus = "REJECTED";
        return false;
    }

    public override double CalculateEMI()
    {
        return CalculateEMIFormula();
    }

    private double CalculateEMIFormula()
    {
        double P = applicant.LoanAmount;
        double R = interestRate / (12 * 100);
        int N = term;

        return (P * R * Math.Pow(1 + R, N)) /
               (Math.Pow(1 + R, N) - 1);
    }
}

// AUTO LOAN 
class AutoLoan : LoanApplication
{
    public AutoLoan(Applicant applicant, int term)
        : base(applicant, term, 9.0) { }

    public override bool ApproveLoan()
    {
        if (BasicEligibility())
        {
            LoanStatus = "APPROVED";
            return true;
        }

        LoanStatus = "REJECTED";
        return false;
    }

    public override double CalculateEMI()
    {
        return CalculateEMIFormula();
    }

    private double CalculateEMIFormula()
    {
        double P = applicant.LoanAmount;
        double R = interestRate / (12 * 100);
        int N = term;

        return (P * R * Math.Pow(1 + R, N)) /
               (Math.Pow(1 + R, N) - 1);
    }
}

// MAIN PROGRAM 
class Program
{
    static void Main()
    {
        Console.Write("Enter Applicant Name: ");
        string name = Console.ReadLine();

        Console.Write("Enter Credit Score: ");
        int score = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter Monthly Income: ");
        double income = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter Loan Amount: ");
        double amount = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter Loan Term (months): ");
        int term = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Choose Loan Type:");
        Console.WriteLine("1. Home Loan");
        Console.WriteLine("2. Auto Loan");
        int choice = Convert.ToInt32(Console.ReadLine());

        Applicant applicant = new Applicant(name, score, income, amount);
        LoanApplication loan;

        if (choice == 1)
            loan = new HomeLoan(applicant, term);
        else
            loan = new AutoLoan(applicant, term);

        bool approved = loan.ApproveLoan();

        Console.WriteLine("Loan Status: " + loan.GetLoanStatus());

        if (approved)
        {
            Console.WriteLine("Monthly EMI: " + loan.CalculateEMI());
        }
        else
        {
            Console.WriteLine("Loan Rejected due to eligibility criteria.");
        }
    }
}
