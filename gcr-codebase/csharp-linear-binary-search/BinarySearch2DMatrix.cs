using System;

class BinarySearch2DMatrix
{
    static void Main()
    {
        Console.WriteLine("Enter number of rows and columns:");
        int rows = int.Parse(Console.ReadLine());
        int cols = int.Parse(Console.ReadLine());
        int[,] matrix = new int[rows, cols];

        Console.WriteLine("Enter the elements row-wise:");
        for (int i = 0; i < rows; i++)
            for (int j = 0; j < cols; j++)
                matrix[i, j] = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter the target value:");
        int target = int.Parse(Console.ReadLine());

        int r = 0, c = cols - 1;
        bool found = false;

        while (r < rows && c >= 0)
        {
            if (matrix[r, c] == target)
            {
                found = true;
                break;
            }
            else if (matrix[r, c] > target)
                c--;
            else
                r++;
        }

        if (found)
            Console.WriteLine("Target found at position (" + r + "," + c + ")");
        else
            Console.WriteLine("Target not found in the matrix.");
    }
}
