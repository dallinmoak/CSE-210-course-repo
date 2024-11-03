class Assignment
{
    public Assignment(string studentName, string topic)
    {
        this._studentName = studentName;
        this._topic = topic;
    }
    private string _studentName;
    private string _topic;

    protected string StudentName
    {
        get { return this._studentName; }
    }
    public string GetSummary()
    {
        return $"{this._studentName} - {this._topic}";
    }
}