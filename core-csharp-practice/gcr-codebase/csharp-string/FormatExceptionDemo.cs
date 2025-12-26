using System;

class FormatExceptionDemo{

    // Method to show exception
    static void ShowException(){
        try{
            string text="abc";
            int number=int.Parse(text);
            Console.WriteLine(number);
        }
        catch(FormatException){
            Console.WriteLine("FormatException");
        }
    }

    static void Main(string[] args){
        ShowException();
    }
}
