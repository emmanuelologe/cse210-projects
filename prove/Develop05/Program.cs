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
        Console.WriteLine("Choose the type of goal:");
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Eternal Goal");
        Console.WriteLine("3. Checklist Goal");

        Console.Write("Enter your choice: ");
        int choice = int.Parse(Console.ReadLine());

        Console.Write("Enter the name of the goal: ");
        string name = Console.ReadLine();

        Console.Write("Enter the description of the goal: ");
        string description = Console.ReadLine();

        switch (choice)
        {
            case 1:
                Console.Write("Enter the number of points for the simple goal: ");
                int points = int.Parse(Console.ReadLine());
                goals.Add(new SimpleGoal(name, description, points, false));
                break;
            case 2:
                Console.Write("Enter the number of points per record for the eternal goal: ");
                int pointsPerRecord = int.Parse(Console.ReadLine());
                goals.Add(new EternalGoal(name, description, pointsPerRecord, false));
                break;
            case 3:
                Console.Write("Enter the number of points per record for the checklist goal: ");
                int pointsPerRecordChecklist = int.Parse(Console.ReadLine());
                Console.Write("Enter the required number of times to complete the checklist goal: ");
                int requiredTimes = int.Parse(Console.ReadLine());
                goals.Add(new ChecklistGoal(name, description, pointsPerRecordChecklist, requiredTimes, false));
                break;
            default:
                Console.WriteLine("Invalid choice. Goal not created.");
                break;
        }
    }

    static void ShowListOfCreatedGoals()
    {
        Console.WriteLine("List of created goals:");
        foreach (var goal in goals)
        {
            goal.DisplayGoalStatus();
        }
    }

    static void SaveUsersGoalsAndScores()
    {
        Console.Write("Enter the file path to save the goals and scores: ");
        string filePath = Console.ReadLine();

        try
        {
            using (StreamWriter writer = new StreamWriter(filePath))
            {
                writer.WriteLine(userScore); 
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
        catch (Exception ex)
        {
            Console.WriteLine("Error occurred while saving goals and scores: " + ex.Message);
        }
    }

    static void LoadUsersScoresAndGoals()
    {
        Console.Write("Enter the file path to load the goals and scores: ");
        string filePath = Console.ReadLine();

        
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

        if (index < 0 | index >= goals.Count)
        {
            Console.WriteLine("Invalid goal index.");
            return;
        }

        goals[index].MarkCompleted();
        userScore += goals[index].GetPointsEarned();

        Console.WriteLine("Event recorded! Your score has been updated.");
    }
}