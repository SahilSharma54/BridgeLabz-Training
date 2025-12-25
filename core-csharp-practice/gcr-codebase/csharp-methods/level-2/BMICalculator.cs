using System;

class BmiCalculator{
    // Method to calculate BMI for all persons
    static void CalculateBmi(double[,] data){
        for(int index=0;index<10;index++){
            double heightInMeter=data[index,1]/100;
            data[index,2]=data[index,0]/(heightInMeter*heightInMeter);
        }
    }

    // Method to find BMI status
    static string[] FindBmiStatus(double[,] data){
        string[] status=new string[10];

        for(int index=0;index<10;index++){
            double bmi=data[index,2];

            if(bmi<=18.4){
                status[index]="Underweight";
            }
            else{
                if(bmi>=18.5&&bmi<=24.9){
                    status[index]="Normal";
                }
                else{
                    if(bmi>=25.0&&bmi<=39.9){
                        status[index]="Overweight";
                    }
                    else{
                        status[index]="Obese";
                    }
                }
            }
        }

        return status;
    }

    static void Main(string[] args){
        // Creating 2D array to store weight,height and bmi
        double[,] data=new double[10,3];

        // Taking input for weight and height
        for(int index=0;index<10;index++){
            data[index,0]=double.Parse(Console.ReadLine());
            data[index,1]=double.Parse(Console.ReadLine());
        }

        // Calculating BMI
        CalculateBmi(data);

        // Finding BMI status
        string[] status=FindBmiStatus(data);

        // Displaying weight,height,bmi and status
        for(int index=0;index<10;index++){
            Console.WriteLine(data[index,0]);
            Console.WriteLine(data[index,1]);
            Console.WriteLine(data[index,2]);
            Console.WriteLine(status[index]);
        }
    }
}
