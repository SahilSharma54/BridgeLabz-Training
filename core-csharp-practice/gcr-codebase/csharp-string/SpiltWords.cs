using System;

class SplitWords{

    // Method to calculate length without Length
    static int GetLength(string text){
        int count=0;
        foreach(char c in text){
            count++;
        }
        return count;
    }

    // Method to split words
    static string[,] SplitText(string text){
        string[,] result=new string[100,2];
        string word="";
        int index=0;

        for(int number=0;number<text.Length;number++){
            if(text[number]!=' '){
                word+=text[number];
            }
            else{
                result[index,0]=word;
                result[index,1]=GetLength(word).ToString();
                index++;
                word="";
            }
        }

        result[index,0]=word;
        result[index,1]=GetLength(word).ToString();

        return result;
    }

    static void Main(string[] args){
		
		// Taking the input from the user
		
        string text=Console.ReadLine();

        string[,] result=SplitText(text);

		//Displaying the results
		
        for(int number=0;number<result.GetLength(0);number++){
            if(result[number,0]!=null){
                Console.WriteLine(result[number,0]);
                Console.WriteLine(result[number,1]);
            }
        }
    }
}
