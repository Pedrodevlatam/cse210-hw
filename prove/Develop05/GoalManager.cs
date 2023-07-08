using System;
using System.Collections.Generic;
using System.IO;

class GoalManager
{
    private List<Goal> goals;
    private int score;

    public GoalManager()
    {
        goals = new List<Goal>();
        score = 0;
    }

    public void CreateGoal()
    {
        Console.WriteLine("The types of goals are:");
        Console.WriteLine("1. Simple goal");
        Console.WriteLine("2. Eternal goal");
        Console.WriteLine("3. Checklist goal");

        Console.Write("Which type of goal would you like to create? ");
        int goalType;
        int.TryParse(Console.ReadLine(), out goalType);

        Console.Write("What is the name of your goal? ");
        string name = Console.ReadLine();

        Console.Write("What is a short description of it? ");
        string description = Console.ReadLine();

        Console.Write("What is the amount of points associated with this goal? ");
        int points;
        int.TryParse(Console.ReadLine(), out points);

        switch (goalType)
        {
            case 1:
                SimpleGoal simpleGoal = new SimpleGoal
                {
                    Name = name,
                    Description = description,
                    Points = points
                };
                goals.Add(simpleGoal);
                break;
            case 2:
                EternalGoal eternalGoal = new EternalGoal
                {
                    Name = name,
                    Description = description,
                    Points = points
                };
                goals.Add(eternalGoal);
                break;
            case 3:
                Console.Write("How many times does this goal need to be accomplished for a bonus? ");
                int requiredTimes;
                int.TryParse(Console.ReadLine(), out requiredTimes);

                Console.Write("What is the bonus for accomplishing it that many times? ");
                int bonus;
                int.TryParse(Console.ReadLine(), out bonus);

                ChecklistGoal checklistGoal = new ChecklistGoal
                {
                    Name = name,
                    Description = description,
                    Points = points,
                    RequiredTimes = requiredTimes,
                    Bonus = bonus
                };
                goals.Add(checklistGoal);
                break;
            default:
                Console.WriteLine("Invalid goal type.");
                break;
        }

        Console.WriteLine("Goal created successfully!");
    }

    public void ListGoals()
    {
        if (goals.Count == 0)
        {
            Console.WriteLine("No goals found.");
            return;
        }

        Console.WriteLine("Your goals are:");
        for (int i = 0; i < goals.Count; i++)
        {
            Console.Write($"{i + 1} ");
            goals[i].Display();
        }
    }

    public void SaveGoals()
    {
    Console.Write("What is the file name for the goals file? ");
    string fileName = Console.ReadLine();

    using (StreamWriter writer = new StreamWriter(fileName))
    {
        foreach (Goal goal in goals)
        {
            writer.Write($"{goal.GetType().Name},{goal.Name},{goal.Description},{goal.Points},{goal.Completed}");

            if (goal is ChecklistGoal checklistGoal)
            {
                writer.Write($",{checklistGoal.RequiredTimes},{checklistGoal.TimesCompleted},{checklistGoal.Bonus}");
            }

            writer.WriteLine();
        }

        writer.WriteLine(score);
    }

        Console.WriteLine("Goals saved successfully!");
    }

    public void LoadGoals()
    {
        Console.Write("What is the file name for the goals file? ");
        string fileName = Console.ReadLine();

        if (!File.Exists(fileName))
        {
            Console.WriteLine("File not found.");
            return;
        }

        goals.Clear();

        using (StreamReader reader = new StreamReader(fileName))
        {
            string line;
            while ((line = reader.ReadLine()) != null)
            {
                string[] parts = line.Split(',');

                switch (parts[0])
                {
                    case nameof(SimpleGoal):
                        SimpleGoal simpleGoal = new SimpleGoal
                        {
                            Name = parts[1],
                            Description = parts[2],
                            Points = int.Parse(parts[3]),
                            Completed = bool.Parse(parts[4])
                        };
                        goals.Add(simpleGoal);
                        break;
                    case nameof(EternalGoal):
                        EternalGoal eternalGoal = new EternalGoal
                        {
                            Name = parts[1],
                            Description = parts[2],
                            Points = int.Parse(parts[3]),
                            Completed = bool.Parse(parts[4])
                        };
                        goals.Add(eternalGoal);
                        break;
                    case nameof(ChecklistGoal):
                        ChecklistGoal checklistGoal = new ChecklistGoal
                        {
                            Name = parts[1],
                            Description = parts[2],
                            Points = int.Parse(parts[3]),
                            Completed = bool.Parse(parts[4]),
                            RequiredTimes = int.Parse(parts[5]),
                            TimesCompleted = int.Parse(parts[6]),
                            Bonus = int.Parse(parts[7])
                        };
                        goals.Add(checklistGoal);
                        break;
                    default:
                        Console.WriteLine("Invalid goal type.");
                        break;
                }
            }

            if ((line = reader.ReadLine()) != null)
            {
                score = int.Parse(line);
            }
        }

        Console.WriteLine("Goals loaded successfully!");
    }

    public void RecordEvent()
    {
        if (goals.Count == 0)
        {
            Console.WriteLine("No goals found. Please create a goal first.");
            return;
        }

        ListGoals();

        Console.Write("Which goal did you accomplish? ");
        int goalIndex;
        int.TryParse(Console.ReadLine(), out goalIndex);

        if (goalIndex < 1 || goalIndex > goals.Count)
        {
            Console.WriteLine("Invalid goal index.");
            return;
        }

        Goal goal = goals[goalIndex - 1];
        if (goal.Completed)
        {
            Console.WriteLine("This goal has already been completed.");
            return;
        }

        goal.RecordEvent();
        score += goal.Points;

        Console.WriteLine($"Now you have {score} points.");
    }
}
