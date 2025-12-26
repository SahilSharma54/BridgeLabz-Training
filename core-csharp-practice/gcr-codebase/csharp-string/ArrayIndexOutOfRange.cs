using System;

class ArrayIndexOutOfRange{

    // Method to show exception
    static void ShowException(){
        try{
            int[] numbers={1,2,3};
            Console.WriteLine(numbers[5]);
        }
        catch(IndexOutOfRangeException){
            Console.WriteLine("IndexOutOfRangeException");
        }
    }

    static void Main(string[] args){
        ShowException();
    }
}
