using System;

namespace ActivityProgram
{
    class ReflectionActivity : Activity
    {
        private string[] prompts = {
            "Think of a time when you stood up for someone else.",
            "Think of a time when you did something really difficult.",
            "Think of a time when you helped someone in need.",
            "Think of a time when you did something truly selfless."
        };

        private string[] questions = {
            "Why was this experience meaningful to you?",
            "Have you ever done anything like this before?",
            "How did you get started?",
            "How did you feel when it was complete?",
            "What made this time different than other times when you were not as successful?",
            "What is your favorite thing about this experience?",
            "What could you learn from this experience that applies to other situations?",
            "What did you learn about yourself through this experience?",
            "How can you keep this experience in mind in the future?"
        };

        public override void StartActivity()
        {
            ShowStartingMessage("Reflection Activity", "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.");

            Random random = new Random();
            int randomPromptIndex = random.Next(prompts.Length);
            string prompt = prompts[randomPromptIndex];

            Console.WriteLine($"\nPrompt: {prompt}");

            Console.WriteLine("Do you have something in mind? Press Enter to continue...");
            Console.ReadLine();

            int questionCount = 1;
            int remainingTime = duration;

            while (remainingTime > 0 && questionCount <= questions.Length)
            {
                Console.WriteLine();

                Console.WriteLine($"Question {questionCount}: {questions[questionCount - 1]}");
                PauseWithAnimation(" ", 5);

                Console.WriteLine("Press Enter to continue...");
                Console.ReadLine();

                questionCount++;
                remainingTime -= 5;
            }

            ShowEndingMessage();
        }
    }
}
