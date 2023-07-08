abstract class Goal
{
    public string Name { get; set; }
    public string Description { get; set; }
    public int Points { get; set; }
    public bool Completed { get; set; }

    public abstract void Display();
    public abstract void RecordEvent();
}
