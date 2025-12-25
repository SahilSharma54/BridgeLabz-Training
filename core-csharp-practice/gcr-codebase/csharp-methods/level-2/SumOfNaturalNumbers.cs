using System;

class SumOfNaturalNumbers{
    static int FindSumUsingRecursion(int number){
        if(number==0){
            return 0;
        }
        return number+FindSumUsingRecursion(number-1);
    }

    static int FindSumUsingFormula(int number){
        return (number*(number+1))/2;
    }

    static void Main(string[] args){
        int number=int.Parse(Console.ReadLine());

        if(number<=0){
            return;
        }

        int recursionSum=FindSumUsingRecursion(number);
        int formulaSum=FindSumUsingFormula(number);

        Console.WriteLine(recursionSum);
        Console.WriteLine(formulaSum);

        if(recursionSum==formulaSum){
            Console.WriteLine("Equal");
        }
		else{
            Console.WriteLine("Not Equal");
        }
    }
}
