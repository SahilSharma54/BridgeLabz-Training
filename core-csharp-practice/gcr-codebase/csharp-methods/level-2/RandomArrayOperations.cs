using System;

class RandomArrayOperations
{
    static int[] Generate4DigitArray(int size){
        // Creating array with fixed 4 digit values
        int[] numbers=new int[]{1234,5678,2345,6789,3456};
        return numbers;
    }

    static double[] FindAverageMinMax(int[] numbers){
        int min=numbers[0];
        int max=numbers[0];
        int sum=0;

        for(int iterator=0;iterator<numbers.Length;iterator++){
            sum+=numbers[iterator];
            min=Math.Min(min,numbers[iterator]);
            max=Math.Max(max,numbers[iterator]);
        }

        double average=(double)sum/numbers.Length;
        return new double[]{average,min,max};
    }

    static void Main(string[] args){
        int[] numbers=Generate4DigitArray(5);
        double[] result=FindAverageMinMax(numbers);

        for(int iterator=0;iterator<numbers.Length;iterator++){
            Console.WriteLine(numbers[iterator]);
        }

        for(int iterator=0;iterator<result.Length;iterator++){
            Console.WriteLine(result[iterator]);
        }
    }
}
