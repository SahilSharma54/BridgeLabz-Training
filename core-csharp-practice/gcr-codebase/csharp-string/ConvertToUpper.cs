using System;

class ConvertToUpper{

    // Method to convert to uppercase
    static string ToUpperCase(string text){
        string result="";
        for(int number=0;number<text.Length;number++){
            char ch=text[number];
            if(ch>='a'&&ch<='z'){
                ch=(char)(ch-32);
            }
            result+=ch;
        }
        return result;
    }

    static void Main(string[] args){

		// Taking the input from the user
		
        string text=Console.ReadLine();

        string result=ToUpperCase(text);
		
		// Display the results
        Console.WriteLine(result);

        Console.WriteLine(text.ToUpper());
    }
}
