using System;

class CreateSubstring{

    // Method to create substring
    static string SubstringCreate(string text,int start,int end){
        string result="";
        for(int number=start;number<=end;number++){
            result+=text[number];
        }
        return result;
    }

    static void Main(string[] args){

        // Taking input
        string text=Console.ReadLine();
        int start=int.Parse(Console.ReadLine());
        int end=int.Parse(Console.ReadLine());

        // Calling method
        string result=SubstringCreate(text,start,end);
        Console.WriteLine(result);

        // Built-in substring
        Console.WriteLine(text.Substring(start,(end-start)+1));
    }
}
