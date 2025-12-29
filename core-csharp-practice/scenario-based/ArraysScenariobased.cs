/*

Arrays – Temperature Analyzer
 1. Scenario: You're analyzing a week’s worth of hourly temperature data stored in a 2D array
(float[7][24]).
Problem:
Write a method to:
 ● Find the hottest and coldest day,
 ● Return average temperature per day.

 2. Scenario: Develop a program to manage student test scores. The program should:
 ● Store the scores of n students in an array.
 ● Calculate and display the average score.
 ● Find and display the highest and lowest scores.
 ● Identify and display the scores above the average.
 ● Handle invalid input like negative scores or non-numeric input.
 
*/

using System;

class ArraysScenarioBased{

    //TEMPERATURE ANALYZER
    static void TemperatureAnalyzer(){

        // 2D array to store temperature of 7 days and 24 hours each
        float[,] temp=new float[7,24];

        Console.WriteLine("Enter temperature for 7 days (24 hours each):");

        // Taking input for each day and hour
        for(int i=0; i<7 ;i++){
            Console.WriteLine("Day "+(i + 1));
            for(int j=0; j<24 ;j++){
                temp[i,j]=float.Parse(Console.ReadLine());
            }
        }

        // Initialize hottest and coldest values
        float hottest=temp[0, 0];
        float coldest=temp[0, 0];
        int hotDay=0,coldDay=0;

        // Loop to calculate average, hottest and coldest day
        for (int i=0;i<7;i++){
            float sum=0;

            for (int j=0;j<24;j++){
                sum+=temp[i,j];

                // Check for hottest temperature
                if(temp[i,j]>hottest){
                    hottest=temp[i,j];
                    hotDay=i;
                }

                // Check for coldest temperature
                if (temp[i,j]<coldest){
                    coldest=temp[i,j];
                    coldDay=i;
                }
            }

            // Display average temperature of each day
            Console.WriteLine("Average temperature of Day "+(i + 1)+" = "+(sum / 24));
        }

        // Display hottest and coldest day
        Console.WriteLine("Hottest Day: Day " +(hotDay + 1));
        Console.WriteLine("Coldest Day: Day " +(coldDay + 1));
    }

    // STUDENT SCORE ANALYZER
    static void StudentScores(){

        Console.WriteLine("Enter number of students:");
        int n=int.Parse(Console.ReadLine());

        int[] scores=new int[n];
        int sum=0;

        // Input student scores
        for (int i=0;i < n;i++){
            Console.WriteLine("Enter score for student "+(i + 1));
            int score=int.Parse(Console.ReadLine());

            // Check for invalid score
            if(score < 0){
                Console.WriteLine("Invalid score. Enter again.");
                i--;
                continue;
            }

            scores[i]=score;
            sum += score;
        }

        // Initialize highest and lowest score
        int highest=scores[0];
        int lowest=scores[0];

        // Find highest and lowest score
        for (int i=1; i<n ;i++){
            if(scores[i] > highest)
                highest = scores[i];

            if(scores[i] < lowest)
                lowest = scores[i];
        }

        // Calculate average score
        float average=sum/(float)n;

        // Display results
        Console.WriteLine("Average Score: " +average);
        Console.WriteLine("Highest Score: " +highest);
        Console.WriteLine("Lowest Score: " +lowest);

        // Display scores above average
        Console.WriteLine("Scores above average:");
        for(int i = 0; i<n ; i++){
            if(scores[i]>average)
                Console.WriteLine(scores[i]);
        }
    }

    // MAIN METHOD
    static void Main(String[] args){

		Console.WriteLine("============================MENU============================");
        Console.WriteLine("1. Temperature Analyzer");
        Console.WriteLine("2. Student Score Analyzer");

        int selection=int.Parse(Console.ReadLine());

        // Menu selection
        switch (selection){
            case 1:
                TemperatureAnalyzer();
                break;

            case 2:
                StudentScores();
                break;
        }
    }
}
