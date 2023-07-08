class EternalGoal : Goal
{
    public override void Display()
    {
        Console.WriteLine($"[ ]{Name} - Description: {Description}");
    }

    public override void RecordEvent()
    {
        Console.WriteLine($"Congratulations! You have earned {Points} points!");
    }
}
