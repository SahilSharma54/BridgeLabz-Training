

/*


ExamProctor – Online Exam Review System (Stack)
Story: During an online exam, each student’s question navigation is recorded using a Stack
(last visited question). Answers are stored in a HashMap: questionID → answer.
A function auto-calculates the score once the student submits.
Requirements:
● Track navigation with stack.
● Store answers in a map.
● Evaluate using functions for scoring logic.


*/

using System;

// ---------------- STACK USING ARRAY ----------------
class QuestionStack
{
    private int[] stack;
    private int top;
    private int size;

    public QuestionStack(int size)
    {
        this.size = size;
        stack = new int[size];
        top = -1;
    }

    // Push visited question ID
    public void Push(int questionId)
    {
        if (top == size - 1)
        {
            Console.WriteLine("Navigation stack full.");
            return;
        }

        stack[++top] = questionId;
    }

    // Pop last visited question
    public int Pop()
    {
        if (top == -1)
        {
            Console.WriteLine("No previous question.");
            return -1;
        }

        return stack[top--];
    }

    // Display navigation history
    public void Display()
    {
        if (top == -1)
        {
            Console.WriteLine("No navigation history.");
            return;
        }

        Console.WriteLine("Navigation History (Last Visited First):");
        for (int i = top; i >= 0; i--)
        {
            Console.WriteLine("Question ID: " + stack[i]);
        }
    }
}

// BASE CLASS 
class ExamBase
{
    // Array to store answers
    protected string[] answers;

    public ExamBase(int totalQuestions)
    {
        answers = new string[totalQuestions + 1]; // index = questionID
    }
}

// DERIVED CLASS 
class ExamProctor : ExamBase
{
    private QuestionStack navigationStack;
    private int totalQuestions;

    public ExamProctor(int totalQuestions) : base(totalQuestions)
    {
        this.totalQuestions = totalQuestions;
        navigationStack = new QuestionStack(totalQuestions);
    }

    // Visit a question
    public void VisitQuestion(int questionId)
    {
        if (questionId > totalQuestions || questionId <= 0)
        {
            Console.WriteLine("Invalid Question ID.");
            return;
        }

        navigationStack.Push(questionId);
        Console.WriteLine("Visited Question " + questionId);
    }

    // Store answer in array
    public void AnswerQuestion(int questionId, string answer)
    {
        if (questionId > totalQuestions || questionId <= 0)
        {
            Console.WriteLine("Invalid Question ID.");
            return;
        }

        answers[questionId] = answer;
        Console.WriteLine("Answer saved.");
    }

    // Show question navigation
    public void ShowNavigation()
    {
        navigationStack.Display();
    }

    // FUNCTION FOR SCORING 
    public void EvaluateExam()
    {
        int score = 0;

        // Hardcoded correct answers (example)
        if (answers[1] == "red" || answers[1] == "Red") score++;
        if (answers[2] == "green" || answers[2] == "Green") score++;
        if (answers[3] == "blue" || answers[3] == "blue") score++;

        Console.WriteLine("Final Score: " + score + "/3");
    }
}

// MAIN CLASS 
class Program
{
    static void Main(string[] args)
    {
        ExamProctor exam = new ExamProctor(5); // Total questions = 5
        int choice;

        do
        {
            Console.WriteLine("--- Exam Proctor Menu ---");
            Console.WriteLine("1. Visit Question");
            Console.WriteLine("2. Answer Question");
            Console.WriteLine("3. Show Navigation History");
            Console.WriteLine("4. Submit Exam");
            Console.WriteLine("5. Exit");
            Console.Write("Enter choice: ");

            choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Console.Write("Enter Question ID: ");
                    exam.VisitQuestion(int.Parse(Console.ReadLine()));
                    break;

                case 2:
                    Console.Write("Enter Question ID: ");
                    int qid = int.Parse(Console.ReadLine());

                    Console.Write("Enter Answer: ");
                    exam.AnswerQuestion(qid, Console.ReadLine());
                    break;

                case 3:
                    exam.ShowNavigation();
                    break;

                case 4:
                    exam.EvaluateExam();
                    break;

                case 5:
                    Console.WriteLine("Exam finished.");
                    break;

                default:
                    Console.WriteLine("Invalid choice.");
                    break;
            }

        } while (choice != 5);
    }
}











