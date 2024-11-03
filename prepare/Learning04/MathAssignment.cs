class MathAssignment : Assignment
{
    public MathAssignment(string studentName, string topic, string textbookSection, string problems) : base(studentName, topic)
    {
        this._textbookSection = textbookSection;
        this._problems = problems;
    }
    private string _textbookSection;
    private string _problems;
    public string GetHomeworkList()
    {
        return $"Section {_textbookSection} Problems {_problems}";
    }
}
