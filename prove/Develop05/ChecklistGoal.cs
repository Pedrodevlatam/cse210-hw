class ChecklistGoal : Goal
{
    public int RequiredTimes { get; set; }
    public int TimesCompleted { get; set; }
    public int Bonus { get; set; }

    public override void Display()
    {
        string status = Completed ? "[X]" : "[ ]";
        Console.WriteLine($"{status}{Name} - Description: {Description} -- Currently completed: {TimesCompleted}/{RequiredTimes} times");
    }

    public override void RecordEvent()
    {
        TimesCompleted++;
        if (TimesCompleted == RequiredTimes)
        {
            Completed = true;
            Console.WriteLine($"Congratulations! You have earned {Points} points and a bonus of {Bonus} points!");
        }
        else
        {
            Console.WriteLine($"Congratulations! You have earned {Points} points!");
        }
    }
}
