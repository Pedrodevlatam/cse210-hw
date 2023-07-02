public class MathAssignment : Assignment
{
    private string _textbookSection;
    private string _problems;

// Take note of the syntax used in this code snippet. The MathAssignment constructor has four parameters,
// and it directly passes two of them to the "base" constructor, which is the constructor of the "Assignment" class.

    public MathAssignment(string studentName, string topic, string textbookSection, string problems)
        : base(studentName, topic)
    {
        // Here we set the MathAssignment specific variables
        _textbookSection = textbookSection;
        _problems = problems;
    }

    public string GetHomeworkList()
    {
        return $"Section {_textbookSection} Problems {_problems}";
    }
}