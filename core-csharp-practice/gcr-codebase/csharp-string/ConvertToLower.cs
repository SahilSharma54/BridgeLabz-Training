using System;

class ConvertToLower{

    // Method to convert to lowercase
    static string ToLowerCase(string text){
        string result="";
        for(int number=0;number<text.Length;number++){
            char ch=text[number];
            if(ch>='A'&&ch<='Z'){
                ch=(char)(ch+32);
            }
            result+=ch;
        }
        return result;
    }

    static void Main(string[] args){

		// Taking the input from the user
        string text=Console.ReadLine();

        string result=ToLowerCase(text);
		
		// Dispaying the result
        Console.WriteLine(result);

        Console.WriteLine(text.ToLower());
    }
}
