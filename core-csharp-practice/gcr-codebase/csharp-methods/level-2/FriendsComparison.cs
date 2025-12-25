using System;

class FriendsComparison{
	
    // Method to find youngest friend
    static string FindYoungest(int[] ages,string[] names){
        int minimumAge=ages[0];
        string youngestFriend=names[0];

        for(int index=1;index<ages.Length;index++){
            if(ages[index]<minimumAge){
                minimumAge=ages[index];
                youngestFriend=names[index];
            }
        }

        return youngestFriend;
    }

    // Method to find tallest friend
    static string FindTallest(double[] heights,string[] names){
        double maximumHeight=heights[0];
        string tallestFriend=names[0];

        for(int index=1;index<heights.Length;index++){
            if(heights[index]>maximumHeight){
                maximumHeight=heights[index];
                tallestFriend=names[index];
            }
        }
        return tallestFriend;
    }

    static void Main(string[] args){
        // Creating array for names
        string[] names={"Amar","Akbar","Anthony"};

        // Creating arrays for age and height
        int[] ages=new int[3];
        double[] heights=new double[3];

        // Taking age input
        for(int index=0;index<ages.Length;index++){
            ages[index]=int.Parse(Console.ReadLine());
        }

        // Taking height input
        for(int index=0;index<heights.Length;index++){
            heights[index]=double.Parse(Console.ReadLine());
        }

        Console.WriteLine(FindYoungest(ages,names));
        Console.WriteLine(FindTallest(heights,names));
    }
}
