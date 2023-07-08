class SimpleGoal : Goal
{
    public override void Display()
    {
        string status = Completed ? "[X]" : "[ ]";
        Console.WriteLine($"{status}{Name} - Description: {Description}");
    }

    public override void RecordEvent()
    {
        Completed = true;
        Console.WriteLine($"Congratulations! You have earned {Points} points!");
    }
}
