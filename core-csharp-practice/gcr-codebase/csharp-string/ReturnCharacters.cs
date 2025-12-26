using System;

class ReturnCharacters{

    // Method to return characters
    static char[] GetCharacters(string text){
        char[] result=new char[text.Length];
        for(int number=0;number<text.Length;number++){
            result[number]=text[number];
        }
        return result;
    }

    static void Main(string[] args){

        // Taking input
        string text=Console.ReadLine();

        // Custom method
        char[] result=GetCharacters(text);
        for(int number=0;number<result.Length;number++){
            Console.WriteLine(result[number]);
        }

        // Built-in method
        char[] builtIn=text.ToCharArray();
        for(int number=0;number<builtIn.Length;number++){
            Console.WriteLine(builtIn[number]);
        }
    }
}
