using System;

namespace ActivityProgram
{
    abstract class Activity
    {
        protected int duration;

        protected void ShowStartingMessage(string activityName, string description)
        {
            Console.WriteLine();
            Console.WriteLine("**************************************************");
            Console.WriteLine($"Activity: {activityName}");
            Console.WriteLine(description);
            Console.WriteLine("**************************************************");

            Console.Write("Enter the duration of the activity (in seconds): ");
            duration = Convert.ToInt32(Console.ReadLine());
        }

        protected void PauseWithAnimation(string message, int seconds)
        {
            Console.Write(message);

            for (int i = seconds; i >= 0; i--)
            {
                Console.Write($"\r{i} ");
                System.Threading.Thread.Sleep(1000);
            }

            Console.WriteLine();
        }

        protected void ShowEndingMessage()
        {
            Console.WriteLine("\n**************************************************");
            Console.WriteLine("Good job! You have completed the activity.");
            Console.WriteLine($"Time spent: {duration} seconds");
            Console.WriteLine("**************************************************");
        }

        public abstract void StartActivity();
    }
}
