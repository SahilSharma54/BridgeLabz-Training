using System;

class QuadraticRoots
{
    static double[] FindRoots(int a,int b,int c){
        // Calculating delta value
        double delta=Math.Pow(b,2)-4*a*c;

        if(delta>0){
            double root1=(-b+Math.Sqrt(delta))/(2*a);
            double root2=(-b-Math.Sqrt(delta))/(2*a);
            return new double[]{root1,root2};
        }
        else if(delta==0){
            double root=(-b)/(2*a);
            return new double[]{root};
        }
        else{
            return new double[]{};
        }
    }

    static void Main(string[] args){
        Console.Write("Enter a: ");
        int a=int.Parse(Console.ReadLine());

        Console.Write("Enter b: ");
        int b=int.Parse(Console.ReadLine());

        Console.Write("Enter c: ");
        int c=int.Parse(Console.ReadLine());

        double[] roots=FindRoots(a,b,c);

        for(int iterator=0;iterator<roots.Length;iterator++){
            Console.WriteLine(roots[iterator]);
        }
    }
}
