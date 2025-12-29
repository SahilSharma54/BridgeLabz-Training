/*  

Strings – Sentence Formatter
1. Scenario: A text editing tool receives poorly formatted input from users. Your task is to auto-correct formatting by fixing spacing and capitalizing the first letter of each sentence.
Problem:
Write a method that takes a paragraph as input and returns a corrected version with:
● One space after punctuation,
● Capital letter after period/question/exclamation marks,
● Trimmed extra spaces.

2. Scenario: Create a program that analyzes a given paragraph of text. Implement the following
functionalities:
● Count the number of words in the paragraph.
● Find and display the longest word.
● Replace all occurrences of a specific word with another word (case-insensitive).
● Handle edge cases like empty strings or paragraphs with only spaces.

*/


using System;

class StringFormatter{

    // Counts number of words in the text
    static int CountWords(string text){
        int count=0;

        // Loop through each character
		
        for (int i=0;i<text.Length;i++){
			
            // Count word when character is not space
            // and previous character is space or start
			
            if (text[i] != ' '&& (i==0 || text[i-1] == ' ')){
                count++;
            }
        }
        return count;
    }

    // Finds the longest word in the text
    static string FindLongestWord(string text){
        string longest="";
        string current="";

        for (int i=0;i<text.Length;i++){
            if(text[i] != ' '){
                current += text[i];
            }
            else{
                if (current.Length > longest.Length){
                    longest=current;
                }
                current="";
            }
        }

        // Check last word
        if (current.Length>longest.Length)
            longest=current;

        return longest;
    }

    // Replaces a word with another word
    static string ReplaceWord(string text, string oldWord, string newWord){
        string result="";
        string temp3="";

        for (int i=0;i <= text.Length;i++){
            if (i<text.Length && text[i] != ' '){
                temp3 += text[i];
            }
            else{
                if(temp3 == oldWord)
                    result += newWord;
                else
                    result += temp3;

                if(i<text.Length)
                    result += " ";

                temp3= "";
            }
        }
        return result;
    }

    // Adds one space after punctuation
    static string OneSpaceAfterPunctuation(string input){
        string temp="";

        for (int i=0;i<input.Length;i++){
            if (input[i] == '.' || input[i] == ',' || input[i] == '?' || input[i] == '!' || input[i] == ':' || input[i] == ';'){
                temp+=input[i]+" ";
            }
            else{
                temp+=input[i];
            }
        }
        return temp;
    }

    // Capitalizes first letter after '.', '!' or '?'
    static string CapitalLetter(string input){
        string temp1 = "";

        for (int i=0;i<input.Length-1;i++){
            if (input[i] == '.' || input[i] == '!' || input[i] == '?'){
                temp1 += input[i];
                temp1 += (char)(input[i+1]-32);
                i++;
            }
            else{
                temp1 += input[i];
            }
        }

        temp1 += input[input.Length-1];
        return temp1;
    }

    // Removes extra spaces
    static string ExtraSpace(string input){
        string temp2="";

        for (int i=0;i<input.Length;i++){
            if ((input[i] == ' ') && (input[i+1] == ' ')){
                temp2 += ' ';
                i++;
            }
            else{
                temp2 += input[i];
            }
        }
        return temp2;
    }

    // Main method in which the menu is present
    static void Main(string[] args){

        Console.WriteLine("============================MENU============================");
        Console.WriteLine("Press 1 : Text Auto Formatting");
        Console.WriteLine("Press 2 : Paragraph Auto Formatting");

        int selection = int.Parse(Console.ReadLine());

        switch (selection){
            case 1:
                Console.WriteLine("Enter the String Text");
                string input = Console.ReadLine();

                string capital = CapitalLetter(input);
                string spaceAfterPunctuation = OneSpaceAfterPunctuation(capital);

                Console.WriteLine(ExtraSpace(spaceAfterPunctuation));
                break;

            case 2:
                Console.WriteLine("Paragraph Formatter");
                string input2 = Console.ReadLine();

                Console.WriteLine("Your Paragraph is : " + input2);
                Console.WriteLine("Your total words are : " + CountWords(input2));
                Console.WriteLine("Your Longest Word is : " + FindLongestWord(input2));

                Console.WriteLine("Want to replace ?");
                Console.WriteLine("Enter the new Word");
                string newWords = Console.ReadLine();

                Console.WriteLine("Enter the old word");
                string oldWords = Console.ReadLine();

                Console.WriteLine(ReplaceWord(input2, oldWords, newWords));
                break;
        }
    }
}
