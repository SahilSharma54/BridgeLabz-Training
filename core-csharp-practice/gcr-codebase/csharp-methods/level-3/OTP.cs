using System;

class OTP{
    // create random object
    static Random random=new Random();

    // generate 6 digit otp
    static int GenerateOTP(){
        int otp=random.Next(100000,1000000);
        return otp;
    }

    // check uniqueness
    static bool AreOTPsUnique(int[] otps){
        for(int iterator=0;iterator<otps.Length;iterator++){
            for(int inner=iterator+1;inner<otps.Length;inner++){
                if(otps[iterator]==otps[inner]){
                    return false;
                }
            }
        }
        return true;
    }

    static void Main(string[] args){
        int[] otps=new int[10];

		// Displaying the results
        for(int iterator=0;iterator<10;iterator++){
            otps[iterator]=GenerateOTP();
            Console.WriteLine(otps[iterator]);
        }
		
        Console.WriteLine(AreOTPsUnique(otps));
    }
}
