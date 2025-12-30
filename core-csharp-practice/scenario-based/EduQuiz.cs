/*

"EduQuiz – Student Quiz Grader"
Story: You’re building the grading module for a quiz app. A student answers a 10-question quiz.
You must compare their answers to the correct ones, give feedback, and calculate scores.
Requirements:
● Use two String[] arrays: correctAnswers[] and studentAnswers[].
● Implement a method calculateScore(String[] correct, String[]
student) that returns a score.
● Use string comparison with .equalsIgnoreCase() for case-insensitive matching.
● Print detailed feedback: Question 1: Correct / Incorrect.
● Bonus: Show percentage score and pass/fail message.

*/


using System;

class EduQuiz{
	
    // Method to calculate score
    static int CalculateScore(string[] correctAnswers, string[] studentAnswers){
		
        int score = 0;
        int len = Math.Min(correctAnswers.Length, studentAnswers.Length); // Ensure no out of bounds

        for (int i=0;i < len;i++){
			
            if (correctAnswers[i].Equals(studentAnswers[i], StringComparison.OrdinalIgnoreCase)){
				
                Console.WriteLine("Question " + (i+1) + ": Correct");
                score++;
            }
            else{
				
                Console.WriteLine("Question " + (i+1) + ": Incorrect (Correct answer: " + correctAnswers[i] + ")");
            }
        }

        return score;
    }

    static void Main(){
		
        // Predefined fruits
        string[] fruits = { "Apple", "Banana", "Grapes", "Orange", "Plum", "Blueberry", "Strawberry", "Coconut", "Kiwi", "Mango" };

        // Predefined correct colors
        string[] correctAnswers = { "Red", "Yellow", "Green", "Orange", "Purple", "Blue", "Red", "Brown", "Green", "Yellow" };

        // Ask user how many questions
        Console.Write("Enter number of questions in the quiz (max " + fruits.Length + "): ");
        int numberOfQuestions = int.Parse(Console.ReadLine());

        if (numberOfQuestions > fruits.Length) numberOfQuestions = fruits.Length; // limit to available fruits

        string[] studentAnswers = new string[numberOfQuestions];

        Console.WriteLine("--- Student, answer the following questions ---");

        // Ask student the questions
        for (int i = 0; i < numberOfQuestions; i++){
			
            Console.Write("Question "+ (i + 1) +": What is the color of "+ fruits[i] +"? ");
            studentAnswers[i] = Console.ReadLine();
        }

        // Calculate score
        int score = CalculateScore(correctAnswers, studentAnswers);

        // Calculate percentage
        double percentage = (score * 100) / numberOfQuestions;

        Console.WriteLine("Total Score: " + score + "/" + numberOfQuestions);
        Console.WriteLine("Percentage: " + percentage + "%");

        if (percentage >= 50){
			
            Console.WriteLine("Result: Pass");
        }
        else{
            Console.WriteLine("Result: Fail");
        }
    }
}
