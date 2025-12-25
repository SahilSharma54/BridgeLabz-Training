using System;

class MatrixOperations{
    // create matrix
    static int[,] CreateMatrix(int rows,int columns){
        int[,] matrix=new int[rows,columns];
        Random random=new Random();
        for(int iterator=0;iterator<rows;iterator++){
            for(int iterator2=0;iterator2<columns;iterator2++){
                matrix[iterator,iterator2]=random.Next(1,10);
            }
        }
        return matrix;
    }

    // add matrices
    static int[,] AddMatrix(int[,] a,int[,] b){
        int[,] result=new int[2,2];
        for(int iterator=0;iterator<2;iterator++){
            for(int iterator2=0;iterator2<2;iterator2++){
                result[iterator,iterator2]=a[iterator,iterator2]+b[iterator,iterator2];
            }
        }
        return result;
    }

    // subtract matrices
    static int[,] SubtractMatrix(int[,] a,int[,] b){
        int[,] result=new int[2,2];
        for(int iterator=0;iterator<2;iterator++){
            for(int iterator2=0;iterator2<2;iterator2++){
                result[iterator,iterator2]=a[iterator,iterator2]-b[iterator,iterator2];
            }
        }
        return result;
    }

    // multiply matrices
    static int[,] MultiplyMatrix(int[,] a,int[,] b){
        int[,] result=new int[2,2];
        for(int iterator=0;iterator<2;iterator++){
            for(int iterator2=0;iterator2<2;iterator2++){
                result[iterator,iterator2]=0;
                for(int iterator3=0;iterator3<2;iterator3++){
                    result[iterator,iterator2]+=a[iterator,iterator3]*b[iterator3,iterator2];
                }
            }
        }
        return result;
    }

    // transpose matrix
    static int[,] TransposeMatrix(int[,] a){
        int[,] result=new int[2,2];
        for(int iterator=0;iterator<2;iterator++){
            for(int iterator2=0;iterator2<2;iterator2++){
                result[iterator2,iterator]=a[iterator,iterator2];
            }
        }
        return result;
    }

    // determinant
    static int FindDeterminant(int[,] a){
        int determinant=(a[0,0]*a[1,1])-(a[0,1]*a[1,0]);
        return determinant;
    }

    // inverse
    static double[,] FindInverse(int[,] a){
        double[,] inverse=new double[2,2];
        int determinant=FindDeterminant(a);

        if(determinant!=0){
            inverse[0,0]=a[1,1]/(double)determinant;
            inverse[0,1]=-a[0,1]/(double)determinant;
            inverse[1,0]=-a[1,0]/(double)determinant;
            inverse[1,1]=a[0,0]/(double)determinant;
        }
        else{
            Console.WriteLine(0);
        }

        return inverse;
    }

    // print int matrix
    static void PrintMatrix(int[,] matrix){
        for(int iterator=0;iterator<2;iterator++){
            for(int iterator2=0;iterator2<2;iterator2++){
                Console.Write(matrix[iterator,iterator2]+" ");
            }
            Console.WriteLine();
        }
    }

    // print double matrix
    static void PrintDoubleMatrix(double[,] matrix){
        for(int iterator=0;iterator<2;iterator++){
            for(int iterator2=0;iterator2<2;iterator2++){
                Console.Write(matrix[iterator,iterator2]+" ");
            }
            Console.WriteLine();
        }
    }

    static void Main(string[] args){
        int[,] matrix1=CreateMatrix(2,2);
        int[,] matrix2=CreateMatrix(2,2);


		// Displaying the results
		
        PrintMatrix(matrix1);
        PrintMatrix(matrix2);

        PrintMatrix(AddMatrix(matrix1,matrix2));
        PrintMatrix(SubtractMatrix(matrix1,matrix2));
        PrintMatrix(MultiplyMatrix(matrix1,matrix2));
        PrintMatrix(TransposeMatrix(matrix1));

        Console.WriteLine(FindDeterminant(matrix1));
        PrintDoubleMatrix(FindInverse(matrix1));
    }
}
