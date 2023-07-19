using System;

class Program
{
    static List<Goal> goals = new List<Goal>();
    static int userScore = 0;

    static void Main()
    {
        int choice;

        do
        {
            Console.WriteLine("1. Create new goal");
            Console.WriteLine("2. Show list of created goals");
            Console.WriteLine("3. Save users' goals and current scores");
            Console.WriteLine("4. Load users' scores and goals");
            Console.WriteLine("5. Record an event");
            Console.WriteLine("6. Quit");

            Console.WriteLine($"Your current score: {userScore}");

            Console.Write("Enter your choice: ");
            choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    CreateNewGoal();
                    break;
                case 2:
                    ShowListOfCreatedGoals();
                    break;
                case 3:
                    SaveUsersGoalsAndScores();
                    break;
                case 4:
                    LoadUsersScoresAndGoals();
                    break;
                case 5:
                    RecordAnEvent();
                    break;
                case 6:
                    Console.WriteLine("Exiting the program. Goodbye!");
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }

            Console.WriteLine();
        } while (choice != 6);
    }

    static void CreateNewGoal()
    {
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Eternal Goal");
        Console.WriteLine("3. Checklist Goal");

        Console.Write("Enter the type of goal you want to create: ");
        int goalType = int.Parse(Console.ReadLine());

        Console.Write("Enter the name of the goal: ");
        string name = Console.ReadLine();

        Console.Write("Enter the description of the goal: ");
        string description = Console.ReadLine();

        int points = 0;
        int requiredTimes = 0;

        switch (goalType)
        {
            case 1:
                Console.Write("Enter the points for completing this goal: ");
                points = int.Parse(Console.ReadLine());
                goals.Add(new SimpleGoal(name, description, points));
                break;
            case 2:
                Console.Write("Enter the points for each record of this goal: ");
                points = int.Parse(Console.ReadLine());
                goals.Add(new EternalGoal(name, description, points));
                break;
            case 3:
                Console.Write("Enter the points for each record of this goal: ");
                points = int.Parse(Console.ReadLine());
                Console.Write("Enter the required number of times to complete this goal: ");
                requiredTimes = int.Parse(Console.ReadLine());
                goals.Add(new ChecklistGoal(name, description, points, requiredTimes));
                break;
            default:
                Console.WriteLine("Invalid goal type.");
                break;
        }
    }

    static void ShowListOfCreatedGoals()
    {
        if (goals.Count == 0)
        {
            Console.WriteLine("No goals created yet.");
            return;
        }

        Console.WriteLine("List of created goals:");
        foreach (var goal in goals)
        {
            goal.DisplayGoalStatus();
        }
    }

    static void SaveUsersGoalsAndScores()
    {
        Console.Write("Enter the file name to save the goals and scores: ");
    string filePath = Console.ReadLine();

    
    using (StreamWriter writer = new StreamWriter(filePath))
    {

        writer.WriteLine($"UserScore: {userScore}");


        foreach (var goal in goals)
        {
            string goalType = goal.GetType().Name;
            string name = goal.Name;
            string description = goal.Description;
            bool isCompleted = goal.IsCompleted;
            writer.WriteLine($"{goalType},{name},{description},{isCompleted}");
        }
    }
    Console.WriteLine("Goals and scores saved successfully.");

    }

    static void LoadUsersScoresAndGoals()
    {
        Console.Write("Enter the file path to load the goals and scores: ");
    string filePath = Console.ReadLine();

    
    goals.Clear();
    using (StreamReader reader = new StreamReader(filePath))
    {
        if (int.TryParse(reader.ReadLine(), out int loadedUserScore))
        {
            userScore = loadedUserScore; // Set the user's score from the file
            string line;
            while ((line = reader.ReadLine()) != null)
            {
                string[] data = line.Split(',');
                string goalType = data[0];
                string name = data[1];
                string description = data[2];
                bool isCompleted = bool.Parse(data[3]);
                switch (goalType)
                {
                    case nameof(SimpleGoal):
                        goals.Add(new SimpleGoal(name, description, 0, isCompleted));
                        break;
                    case nameof(EternalGoal):
                        goals.Add(new EternalGoal(name, description, 0, isCompleted));
                        break;
                    case nameof(ChecklistGoal):
                        goals.Add(new ChecklistGoal(name, description, 0, 0, isCompleted));
                        break;
                    default:
                        Console.WriteLine("Unknown goal type found in file.");
                        break;
                }
            }
        }
        else
        {
            Console.WriteLine("Invalid file format. Couldn't load goals and scores.");
        }
    }
    Console.WriteLine("Goals and scores loaded successfully.");
    
}

    static void RecordAnEvent()
    {
        if (goals.Count == 0)
        {
            Console.WriteLine("No goals created yet.");
            return;
        }

        ShowListOfCreatedGoals();

        Console.Write("Enter the index of the goal you want to record an event for: ");
        int index = int.Parse(Console.ReadLine()) -1;

        if (index < 0 || index >= goals.Count)
        {
            Console.WriteLine("Invalid goal index.");
            return;
        }

        goals[index].MarkCompleted();
        userScore += goals[index].GetPointsEarned();

        Console.WriteLine("Event recorded! Your score has been updated.");
    }
}