using System;

namespace ActivityProgram
{
    class ListingActivity : Activity
    {
        private string[] prompts = {
            "Who are people that you appreciate?",
            "What are personal strengths of yours?",
            "Who are people that you have helped this week?",
            "When have you felt the Holy Ghost this month?",
            "Who are some of your personal heroes?"
        };

        public override void StartActivity()
        {
            ShowStartingMessage("Listing Activity", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.");

            Random random = new Random();
            int randomPromptIndex = random.Next(prompts.Length);
            string prompt = prompts[randomPromptIndex];

            Console.WriteLine($"\nPrompt: {prompt}");

            PauseWithAnimation("  Think about the prompt: ", 4);
            Console.WriteLine("\nBegin listing items:");

            int itemCount = 0;
            int remainingTime = duration;

            while (remainingTime > 0)
            {
                string item = Console.ReadLine();

                if (!string.IsNullOrEmpty(item))
                {
                    itemCount++;
                    remainingTime -= 5;
                }
                else
                {
                    break;
                }
            }

            Console.WriteLine($"\nNumber of items listed: {itemCount}");

            ShowEndingMessage();
        }
    }
}
