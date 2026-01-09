/*

"FitTrack – Fitness Tracker"
● Classes: UserProfile, Workout.
● Interface: ITrackable.
● Types: CardioWorkout, StrengthWorkout.


*/

using System;

class Workout{
	protected int duration;
	protected int calorieBurned;
	protected int progress;
	
	public Workout(int duration,int calorieBurned,int progress){
		this.duration=duration;
		this.calorieBurned=calorieBurned;
		this.progress=progress;
	}
	
}


interface ITrackable{
	void TrackProgress();
	void TrackCalories();
	
}

class CardioWorkout:Workout,ITrackable{
	private string type;
	private int time;
	
	public CardioWorkout(int duration,int calorieBurned,int progress,string type,int time):base(duration,calorieBurned,progress){
		this.type=type;
		this.time=time;
		
	}
	
	public void TrackProgress(){
		Console.WriteLine("Tracking Cardio Workout "+progress+" %");
	}
	
	public void TrackCalories(){
		Console.WriteLine("Calories burned "+calorieBurned+" Joules");
	}
	
}



class StrengthWorkout:Workout,ITrackable{
	private string type;
	private int time;
	
	public StrengthWorkout(int duration,int calorieBurned,int progress,string type,int time):base(duration,calorieBurned,progress){
		this.type=type;
		this.time=time;
		
	}
	
	public void TrackProgress(){
		Console.WriteLine("Tracking Strength Workout"+progress);
	}
	
	public void TrackCalories(){
		Console.WriteLine("Calories burned"+calorieBurned);
	}
	
	
}

class FitnessTracker{
    static void Main(string[] args){
		
		int choice;

        do
        {
            Console.WriteLine("\n===== FitTrack Menu =====");
            Console.WriteLine("1. Cardio Workout");
            Console.WriteLine("2. Strength Workout");
            Console.WriteLine("3. Exit");
            Console.Write("Enter your choice: ");

            choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    // Cardio Workout
                    Console.Write("Enter duration: ");
                    int cDuration = int.Parse(Console.ReadLine());

                    Console.Write("Enter calories burned: ");
                    int cCalories = int.Parse(Console.ReadLine());

                    Console.Write("Enter progress: ");
                    int cProgress = int.Parse(Console.ReadLine());

                    Console.Write("Enter cardio type: ");
                    string cType = Console.ReadLine();

                    Console.Write("Enter time: ");
                    int cTime = int.Parse(Console.ReadLine());

                    CardioWorkout cardio = new CardioWorkout(
                        cDuration, cCalories, cProgress, cType, cTime
                    );

                    cardio.TrackProgress();
                    cardio.TrackCalories();
                    break;

                case 2:
                    // Strength Workout
                    Console.Write("Enter duration: ");
                    int sDuration = int.Parse(Console.ReadLine());

                    Console.Write("Enter calories burned: ");
                    int sCalories = int.Parse(Console.ReadLine());

                    Console.Write("Enter progress: ");
                    int sProgress = int.Parse(Console.ReadLine());

                    Console.Write("Enter strength type: ");
                    string sType = Console.ReadLine();

                    Console.Write("Enter time: ");
                    int sTime = int.Parse(Console.ReadLine());

                    StrengthWorkout strength = new StrengthWorkout(
                        sDuration, sCalories, sProgress, sType, sTime
                    );

                    strength.TrackProgress();
                    strength.TrackCalories();
                    break;

                case 3:
                    Console.WriteLine("Exiting FitTrack...");
                    break;

                default:
                    Console.WriteLine("Invalid choice. Try again.");
                    break;
            }

        } while (choice != 3);
		
	}
}


