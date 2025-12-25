using System;

class FootballTeamHeights
{
    static int FindSum(int[] heights){
        // Calculating sum of heights
        int sum=0;
        for(int iterator=0;iterator<heights.Length;iterator++){
            sum+=heights[iterator];
        }
        return sum;
    }

    static double FindMean(int[] heights){
        // Calculating mean height
        int sum=FindSum(heights);
        return (double)sum/heights.Length;
    }

    static int FindShortest(int[] heights){
        // Finding shortest height
        int shortest=heights[0];
        for(int iterator=0;iterator<heights.Length;iterator++){
            if(heights[iterator]<shortest){
                shortest=heights[iterator];
            }
        }
        return shortest;
    }

    static int FindTallest(int[] heights){
        // Finding tallest height
        int tallest=heights[0];
        for(int iterator=0;iterator<heights.Length;iterator++){
            if(heights[iterator]>tallest){
                tallest=heights[iterator];
            }
        }
        return tallest;
    }

    static void Main(string[] args){
        // Heights of 11 players in cms
        int[] heights=new int[]{165,170,172,168,180,175,169,182,178,171,176};

        Console.WriteLine(FindShortest(heights));
        Console.WriteLine(FindTallest(heights));
        Console.WriteLine(FindMean(heights));
    }
}
