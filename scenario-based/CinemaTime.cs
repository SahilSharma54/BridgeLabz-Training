

/*

"CinemaTime – Movie Schedule Manager"
Story: A cinema manager wants a tool to store and update a list of movie showtimes and titles.
Users should be able to add, view, and search movies.
Requirements:
● Using some Arrays for storing the data
● Method to:
○ addMovie(String title, String time)
○ searchMovie(String keyword) – use String.contains()
○ displayAllMovies()
● Combine titles and times into a formatted string using .format() or concatenation.
● Array when generating printable reports.

*/


using System;

interface IMovieUtility
{
    void AddMovie(string title, string time);
    bool SearchMovie(string keyword);
    void DisplayAllMovies();
}

class MovieCapsule
{
    private string[] movieTitle;
    private string[] movieTime;

    public string[] MovieTitle
    {
        get { return movieTitle; }
        set { movieTitle = value; }
    }

    public string[] MovieTime
    {
        get { return movieTime; }
        set { movieTime = value; }
    }
}

class UtilityImplement : IMovieUtility
{
    MovieCapsule ve = new MovieCapsule();

    public void AddMovie(string title, string time)
    {
        Console.WriteLine("Enter the size of the array");
        int size = int.Parse(Console.ReadLine());

        string[] titles = new string[size];
        string[] times = new string[size];

        for (int i=0;i<size;i++)
        {
            Console.Write("Enter movie title: ");
            titles[i] = Console.ReadLine();

            Console.Write("Enter movie time: ");
            times[i] = Console.ReadLine();
        }

        ve.MovieTitle = titles;
        ve.MovieTime = times;

        Console.WriteLine("Movies added successfully!");
    }

    public bool SearchMovie(string keyword)
    {
        if (ve.MovieTitle == null)
            return false;

        foreach (string s in ve.MovieTitle)
        {
            if (s.Contains(keyword))
            {
                return true;
            }
        }
        return false;
    }

    
    public void DisplayAllMovies()
    {
        if (ve.MovieTitle == null || ve.MovieTime == null)
        {
            Console.WriteLine("No movies to display.");
            return;
        }

        for (int i = 0; i < ve.MovieTitle.Length; i++)
        {
            Console.WriteLine("Movie Name " + ve.MovieTitle[i] + " " + i + " With time is :" + ve.MovieTime[i]);
        }
    }
} 

class Menu
{
    IMovieUtility utility = new UtilityImplement();  // directly created

    public void DisplayMenu()
    {
        int choice = 0;

        while (choice != 4)
        {
            Console.WriteLine("1. Add Movie");
            Console.WriteLine("2. Search Movie");
            Console.WriteLine("3. Display Movies");
            Console.WriteLine("4. Exit");
            Console.Write("Enter your choice: ");

            choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    utility.AddMovie("", "");
                    break;

                case 2:
                    Console.Write("Enter keyword: ");
                    string key = Console.ReadLine();

                    if (utility.SearchMovie(key))
                        Console.WriteLine("Found");
                    else
                        Console.WriteLine("Not Found");
                    break;

                case 3:
                    utility.DisplayAllMovies();
                    break;

                case 4:
                    Console.WriteLine("Exiting...");
                    break;

                default:
                    Console.WriteLine("Invalid choice");
                    break;
            }
        }
    }
}


class Program
{
    public static void Main(string[] args)
    {
        Menu menu = new Menu();
        menu.DisplayMenu();
    }
}
