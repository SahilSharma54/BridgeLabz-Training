
/*

Customer Service Call Log Manager
Scenario: Telecom company tracking call logs. Requirements:
● Store logs in a Array of CallLogs.
● Each log contains PhoneNumber, Message, Timestamp.
● Filter logs by time range, search by keywords in message (string.Contains).
● Methods: AddCallLog(), SearchByKeyword(), FilterByTime().


*/



using System;



class CallLog{
	
    public string PhoneNumber;
    public string Message;
    public string Time;   // time stored as string

    public CallLog(string phone, string message, string time){
		
        PhoneNumber = phone;
        Message = message;
        Time = time;
    }
}



class CallLogManager{
	
    private CallLog[] logs;
    private int count;

    public CallLogManager(int size){
		
        logs = new CallLog[size];
        count = 0;
    }

    // Add Call Log
    public void AddCallLog(CallLog log){
		
        if (count < logs.Length){
			
            logs[count] = log;
            count++;
        }
        else{
			
            Console.WriteLine("Log storage full.");
        }
    }

    // Search by keyword in message
    public void SearchByKeyword(string keyword){
		
        Console.WriteLine("--- Search Results ---");
        for (int i = 0; i < count; i++){
			
            if (logs[i].Message.Contains(keyword)){
				
                PrintLog(logs[i]);
            }
        }
    }

    // Filter by time (string comparison)
    public void FilterByTime(string startTime, string endTime){
		
        Console.WriteLine("\n--- Filtered Logs ---");
        for (int i = 0; i < count; i++){
			
            if (logs[i].Time.CompareTo(startTime) >= 0 &&
                logs[i].Time.CompareTo(endTime) <= 0){
					
                PrintLog(logs[i]);
            }
        }
    }

    private void PrintLog(CallLog log){
		
        Console.WriteLine("Phone: " + log.PhoneNumber +
                          ", Message: " + log.Message +
                          ", Time: " + log.Time);
    }
}



class Program{
	
    static void Main(){
		
        Console.Write("Enter number of call logs: ");
        int size = int.Parse(Console.ReadLine());

        CallLogManager manager = new CallLogManager(size);

        // Taking user input
        for (int i = 0; i < size; i++){
			
            Console.WriteLine("Enter details for Call Log " + (i + 1));

            Console.Write("Phone Number: ");
            string phone = Console.ReadLine();

            Console.Write("Message: ");
            string message = Console.ReadLine();

            Console.Write("Time (HH:MM): ");
            string time = Console.ReadLine();

            manager.AddCallLog(new CallLog(phone, message, time));
        }

        // Search
        Console.Write("\nEnter keyword to search: ");
        string keyword = Console.ReadLine();
        manager.SearchByKeyword(keyword);

        // Filter by time
        Console.Write("\nEnter start time (HH:MM): ");
        string start = Console.ReadLine();

        Console.Write("Enter end time (HH:MM): ");
        string end = Console.ReadLine();

        manager.FilterByTime(start, end);
    }
}
