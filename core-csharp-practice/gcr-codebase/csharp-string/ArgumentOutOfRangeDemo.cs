using System;

class ArgumentOutOfRangeDemo{

    // Method to show exception
    static void ShowException(){
        try{
            string text="Hello";
            Console.WriteLine(text.Substring(4,10));
        }
        catch(ArgumentOutOfRangeException){
            Console.WriteLine("ArgumentOutOfRangeException");
        }
    }

    static void Main(string[] args){
        ShowException();
    }
}
