using System;

namespace ActivityProgram
{
    class BreathingActivity : Activity
    {
        public override void StartActivity()
        {
            ShowStartingMessage("Breathing Activity", "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.");

            Console.WriteLine("Prepare to begin...");
            PauseWithAnimation(" ", 4);

            int count = 1;
            int remainingTime = duration;

            while (remainingTime > 0)
            {
                Console.WriteLine();

                if (count % 2 != 0)
                {
                    Console.WriteLine("Breathe in...");
                    PauseWithAnimation(" ", 4);
                }
                else
                {
                    Console.WriteLine("Now Breathe out...");
                    PauseWithAnimation(" ", 6);
                }

                count++;
                remainingTime -= (count % 2 == 0) ? 6 : 4;
            }

            ShowEndingMessage();
        }
    }
}
