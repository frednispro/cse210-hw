abstract class Goal
{
    protected string _name;
    protected string _desc;
    protected int _points;

    public Goal(string name, string desc, int points)
    {
        _name = name;
        _desc = desc;
        _points = points;
    }

    public abstract int RecordEvent();
    public abstract string GetStatus();
    public abstract string SaveString();

    public static Goal LoadFromString(string s)
    {
        string[] parts = s.Split('|');
        if (parts[0] == "Simple")
            return new SimpleGoal(parts[1], parts[2], int.Parse(parts[3]), bool.Parse(parts[4]));
        if (parts[0] == "Eternal")
            return new EternalGoal(parts[1], parts[2], int.Parse(parts[3]));
        if (parts[0] == "Checklist")
            return new ChecklistGoal(parts[1], parts[2], int.Parse(parts[3]), int.Parse(parts[4]), int.Parse(parts[5]), int.Parse(parts[6]));
        return null;
    }
}
