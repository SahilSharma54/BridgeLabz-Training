using System;

class NullReferenceDemo{

    // Method to show exception
    static void ShowException(){
        try{
            string text=null;
            Console.WriteLine(text.Length);
        }
        catch(NullReferenceException){
            Console.WriteLine("NullReferenceException");
        }
    }

    static void Main(string[] args){
        ShowException();
    }
}
