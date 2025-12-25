using System;

class StudentVoteChecker{
    // Method to check whether student can vote
    static bool CanStudentVote(int age){
        if(age<0){
            return false;
        }
        else{
            if(age>=18){
                return true;
            }
            else{
                return false;
            }
        }
    }


    static void Main(string[] args){
        // Creating array to store age of students
        int[] ages=new int[10];

        // Taking age input and checking voting eligibility
        for(int index=0;index<ages.Length;index++){
            ages[index]=int.Parse(Console.ReadLine());
            Console.WriteLine(CanStudentVote(ages[index]));
        }
    }

}