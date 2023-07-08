using System;

class Program
{
    static void Main()
    {
        GoalManager goalManager = new GoalManager();
        int choice;

        do
        {
            Console.WriteLine("\nMenu options:");
            Console.WriteLine("1. Create a new goal");
            Console.WriteLine("2. List goals");
            Console.WriteLine("3. Save goals");
            Console.WriteLine("4. Load goals");
            Console.WriteLine("5. Record event");
            Console.WriteLine("6. Quit");

            Console.Write("\nSelect a choice from the menu: ");
            int.TryParse(Console.ReadLine(), out choice);
            Console.WriteLine();

            switch (choice)
            {
                case 1:
                    goalManager.CreateGoal();
                    break;
                case 2:
                    goalManager.ListGoals();
                    break;
                case 3:
                    goalManager.SaveGoals();
                    break;
                case 4:
                    goalManager.LoadGoals();
                    break;
                case 5:
                    goalManager.RecordEvent();
                    break;
                case 6:
                    Console.WriteLine("Goodbye!");
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }

        } while (choice != 6);
    }
}
