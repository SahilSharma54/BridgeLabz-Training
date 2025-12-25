using System;

class StudentScore{
	
	// Method to generate random PCM marks
	static int[,] GenerateScores(int numberOfStudents){
		int[,] scores=new int[numberOfStudents,3];
		Random random=new Random();
		
		for(int student=0;student<numberOfStudents;student++){
			scores[student,0]=random.Next(10,100);
			scores[student,1]=random.Next(10,100);
			scores[student,2]=random.Next(10,100);
		}
		
		return scores;
	}
	
	// Method to calculate total,average and percentage
	static double[,] CalculateResults(int[,] scores){
		int numberOfStudents=scores.GetLength(0);
		double[,] results=new double[numberOfStudents,3];
		
		for(int student=0;student<numberOfStudents;student++){
			double total=scores[student,0]+scores[student,1]+scores[student,2];
			double average=total/3;
			double percentage=(total/300)*100;
			
			results[student,0]=Math.Round(total,2);
			results[student,1]=Math.Round(average,2);
			results[student,2]=Math.Round(percentage,2);
		}
		
		return results;
	}
	
	// Method to get grade based on percentage
	static string GetGrade(double percentage){
		if(percentage>=80){
			return "A";
		}
		else if(percentage>=70){
			return "B";
		}
		else if(percentage>=60){
			return "C";
		}
		else if(percentage>=50){
			return "D";
		}
		else if(percentage>=40){
			return "E";
		}
		else{
			return "R";
		}
	}
	
	// Method to display scorecard
	static void DisplayScoreCard(int[,] scores,double[,] results){
		Console.WriteLine("Phy\tChem\tMath\tTotal\tAverage\tPercentage\tGrade");
		
		for(int student=0;student<scores.GetLength(0);student++){
			string grade=GetGrade(results[student,2]);
			
			Console.WriteLine(
				scores[student,0]+"\t"+
				scores[student,1]+"\t"+
				scores[student,2]+"\t"+
				results[student,0]+"\t"+
				results[student,1]+"\t"+
				results[student,2]+"\t"+
				grade
			);
		}
	}
	
	static void Main(string[] args){
		
		// Taking input for number of students
		int numberOfStudents=int.Parse(Console.ReadLine());
		
		// Generating PCM scores
		int[,] scores=GenerateScores(numberOfStudents);
		
		// Calculating results
		double[,] results=CalculateResults(scores);
		
		// Displaying scorecard
		DisplayScoreCard(scores,results);
	}
}
