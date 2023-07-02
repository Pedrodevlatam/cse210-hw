public class WritingAssignment : Assignment
{
    private string _title;

// Pay attention to the syntax used in this code snippet. The WritingAssignment constructor accepts 3 parameters,
// and it proceeds to pass 2 of them directly to the "base" constructor, which is the constructor of the "Assignment" class.

    public WritingAssignment(string studentName, string topic, string title)
        : base(studentName, topic)
    {
    // In this section, we initialize any variables that are specific to the WritingAssignment class.

        _title = title;
    }

    public string GetWritingInformation()
    {
        // Observe that we are utilizing the getter method here since _studentName is a private variable in the base class.

        string studentName = GetStudentName();

        return $"{_title} by {studentName}";
    }
}