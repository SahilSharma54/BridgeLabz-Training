using System;

class EmployeeBonus{
	
	// Method to generate salary and years of service
	static int[,] GenerateEmployeeData(){
		int[,] employeeData=new int[10,2];
		Random random=new Random();
		
		for(int index=0;index<10;index++){
			employeeData[index,0]=random.Next(10000,99999);
			employeeData[index,1]=random.Next(1,11);
		}
		
		return employeeData;
	}
	
	// Method to calculate new salary and bonus
	static double[,] CalculateBonusAndNewSalary(int[,] employeeData){
		double[,] salaryDetails=new double[10,3];
		
		for(int index=0;index<10;index++){
			double oldSalary=employeeData[index,0];
			int yearsOfService=employeeData[index,1];
			double bonus;
			
			if(yearsOfService>5){
				bonus=oldSalary*0.05;
			}
			else{
				bonus=oldSalary*0.02;
			}
			
			double newSalary=oldSalary+bonus;
			
			salaryDetails[index,0]=oldSalary;
			salaryDetails[index,1]=bonus;
			salaryDetails[index,2]=newSalary;
		}
		
		return salaryDetails;
	}
	
	// Method to calculate totals and display result
	static void DisplaySummary(double[,] salaryDetails){
		double totalOldSalary=0;
		double totalBonus=0;
		double totalNewSalary=0;
		
		for(int index=0;index<10;index++){
			totalOldSalary+=salaryDetails[index,0];
			totalBonus+=salaryDetails[index,1];
			totalNewSalary+=salaryDetails[index,2];
		}
		
		Console.WriteLine("OldSalary\tBonus\tNewSalary");
		
		for(int index=0;index<10;index++){
			Console.WriteLine(salaryDetails[index,0]+"\t"+salaryDetails[index,1]+"\t"+salaryDetails[index,2]);
		}
		
		Console.WriteLine(totalOldSalary+"\t"+totalBonus+"\t"+totalNewSalary);
	}
	
	static void Main(string[] args){
		
		// Generating employee data
		int[,] employeeData=GenerateEmployeeData();
		
		// Calculating bonus and new salary
		double[,] salaryDetails=CalculateBonusAndNewSalary(employeeData);
		
		// Displaying final summary
		DisplaySummary(salaryDetails);
	}
}
