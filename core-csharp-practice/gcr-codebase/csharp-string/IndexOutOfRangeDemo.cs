using System;

class IndexOutOfRangeDemo{

    // Method to show exception
    static void ShowException(){
        try{
            string text="Hello";
            Console.WriteLine(text[10]);
        }
        catch(IndexOutOfRangeException){
            Console.WriteLine("IndexOutOfRangeException");
        }
    }

    static void Main(string[] args){
        ShowException();
    }
}
