using System;

class CompareString{

    // Method to compare two strings using charAt
    static bool Compare(string first,string second){
        if(first.Length!=second.Length){
            return false;
        }
        for(int number=0;number<first.Length;number++){
            if(first[number]!=second[number]){
                return false;
            }
        }
        return true;
    }

    static void Main(string[] args){

        // Taking input
        string first=Console.ReadLine();
        string second=Console.ReadLine();

        // Calling method
        bool result=Compare(first,second);
        Console.WriteLine(result);

        // Built-in comparison
        Console.WriteLine(first.Equals(second));
    }
}
