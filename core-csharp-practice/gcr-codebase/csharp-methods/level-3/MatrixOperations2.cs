using System;

class MatrixOperations{
    // display matrix
    static void DisplayMatrix(int[,] matrix){
        for(int iterator=0;iterator<matrix.GetLength(0);iterator++){
            for(int iterator2=0;iterator2<matrix.GetLength(1);iterator2++){
                Console.Write(matrix[iterator,iterator2]+" ");
            }
            Console.WriteLine();
        }
    }

    // transpose of matrix
    static int[,] TransposeMatrix(int[,] matrix){
        int rows=matrix.GetLength(0);
        int columns=matrix.GetLength(1);
        int[,] result=new int[columns,rows];

        for(int iterator=0;iterator<rows;iterator++){
            for(int iterator2=0;iterator2<columns;iterator2++){
                result[iterator2,iterator]=matrix[iterator,iterator2];
            }
        }
        return result;
    }

    // determinant of 2x2 matrix
    static int Determinant2x2(int[,] matrix){
        int determinant=(matrix[0,0]*matrix[1,1])-(matrix[0,1]*matrix[1,0]);
        return determinant;
    }

    // determinant of 3x3 matrix
    static int Determinant3x3(int[,] matrix){
        int determinant=
        matrix[0,0]*(matrix[1,1]*matrix[2,2]-matrix[1,2]*matrix[2,1])-
        matrix[0,1]*(matrix[1,0]*matrix[2,2]-matrix[1,2]*matrix[2,0])+
        matrix[0,2]*(matrix[1,0]*matrix[2,1]-matrix[1,1]*matrix[2,0]);
        return determinant;
    }

    // inverse of 2x2 matrix
    static double[,] Inverse2x2(int[,] matrix){
        double[,] inverse=new double[2,2];
        int determinant=Determinant2x2(matrix);

        if(determinant!=0){
            inverse[0,0]=matrix[1,1]/(double)determinant;
            inverse[0,1]=-matrix[0,1]/(double)determinant;
            inverse[1,0]=-matrix[1,0]/(double)determinant;
            inverse[1,1]=matrix[0,0]/(double)determinant;
        }
        else{
            Console.WriteLine(0);
        }

        return inverse;
    }

    // inverse of 3x3 matrix
    static double[,] Inverse3x3(int[,] matrix){
        double[,] inverse=new double[3,3];
        int determinant=Determinant3x3(matrix);

        if(determinant!=0){
            inverse[0,0]=(matrix[1,1]*matrix[2,2]-matrix[1,2]*matrix[2,1])/(double)determinant;
            inverse[0,1]=(matrix[0,2]*matrix[2,1]-matrix[0,1]*matrix[2,2])/(double)determinant;
            inverse[0,2]=(matrix[0,1]*matrix[1,2]-matrix[0,2]*matrix[1,1])/(double)determinant;

            inverse[1,0]=(matrix[1,2]*matrix[2,0]-matrix[1,0]*matrix[2,2])/(double)determinant;
            inverse[1,1]=(matrix[0,0]*matrix[2,2]-matrix[0,2]*matrix[2,0])/(double)determinant;
            inverse[1,2]=(matrix[0,2]*matrix[1,0]-matrix[0,0]*matrix[1,2])/(double)determinant;

            inverse[2,0]=(matrix[1,0]*matrix[2,1]-matrix[1,1]*matrix[2,0])/(double)determinant;
            inverse[2,1]=(matrix[0,1]*matrix[2,0]-matrix[0,0]*matrix[2,1])/(double)determinant;
            inverse[2,2]=(matrix[0,0]*matrix[1,1]-matrix[0,1]*matrix[1,0])/(double)determinant;
        }
        else{
            Console.WriteLine(0);
        }

        return inverse;
    }

    static void Main(string[] args){
        int[,] matrix2x2={{1,2},{3,4}};
        int[,] matrix3x3={{1,2,3},{0,1,4},{5,6,0}};


		// Displaying the results
		
        DisplayMatrix(matrix2x2);
        Console.WriteLine(Determinant2x2(matrix2x2));
        DisplayMatrix(TransposeMatrix(matrix2x2));

        DisplayMatrix(matrix3x3);
        Console.WriteLine(Determinant3x3(matrix3x3));
        DisplayMatrix(TransposeMatrix(matrix3x3));
    }
}
