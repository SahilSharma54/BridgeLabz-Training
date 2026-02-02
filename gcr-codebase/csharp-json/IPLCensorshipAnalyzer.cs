using System;
using System.IO;
using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

class Program
{
    static void Main()
    {
        Console.WriteLine("IPL Censorship Analyzer");
        Console.WriteLine("1. Process JSON File");
        Console.WriteLine("2. Process CSV File");
        Console.Write("Choose option: ");
        int choice = int.Parse(Console.ReadLine());

        if (choice == 1)
        {
            ProcessJson();
        }
        else if (choice == 2)
        {
            ProcessCsv();
        }
        else
        {
            Console.WriteLine("Invalid choice");
        }
    }

    // JSON PROCESSING 
    static void ProcessJson()
    {
        Console.Write("Enter JSON file path: ");
        string path = Console.ReadLine();

        // Read JSON file
        string jsonData = File.ReadAllText(path);

        // Convert JSON to array
        JArray matches = JArray.Parse(jsonData);

        // Apply censorship rules
        foreach (JObject match in matches)
        {
            match["team1"] = MaskTeam(match["team1"].ToString());
            match["team2"] = MaskTeam(match["team2"].ToString());

            // Mask score teams
            JObject score = (JObject)match["score"];
            foreach (var item in score)
            {
                score[item.Key] = MaskTeam(item.Value.ToString());
            }

            // Mask player of match
            match["player_of_match"] = "REDACTED";
        }

        // Convert back to JSON
        string censoredJson = JsonConvert.SerializeObject(matches, Formatting.Indented);

        // Save output
        File.WriteAllText("censored_output.json", censoredJson);

        Console.WriteLine("Censored JSON saved as censored_output.json");
    }

    // CSV PROCESSING
    static void ProcessCsv()
    {
        Console.Write("Enter CSV file path: ");
        string path = Console.ReadLine();

        // Read all lines
        string[] lines = File.ReadAllLines(path);

        List<string> output = new List<string>();

        // Keep header
        output.Add(lines[0]);

        // Process each row
        for (int i = 1; i < lines.Length; i++)
        {
            string[] parts = lines[i].Split(',');

            // Mask team names
            parts[3] = MaskTeam(parts[3]);
            parts[4] = MaskTeam(parts[4]);
            parts[5] = MaskTeam(parts[5]);

            // Mask player of match
            parts[6] = "REDACTED";

            output.Add(string.Join(",", parts));
        }

        // Save file
        File.WriteAllLines("censored_output.csv", output);

        Console.WriteLine("Censored CSV saved as censored_output.csv");
    }

    // TEAM MASK FUNCTION 
    static string MaskTeam(string team)
    {
        // Split team name into words
        string[] words = team.Split(' ');

        // Replace last word with ***
        words[words.Length - 1] = "***";

        // Join back
        return string.Join(" ", words);
    }
}
