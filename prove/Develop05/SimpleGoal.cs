class SimpleGoal : Goal
{
    private bool _done;

    public SimpleGoal(string name, string desc, int points, bool done = false)
        : base(name, desc, points)
    {
        _done = done;
    }

    public override int RecordEvent()
    {
        if (!_done)
        {
            _done = true;
            return _points;
        }
        return 0;
    }

    public override string GetStatus()
    {
        return $"[{(_done ? "X" : " ")}] {_name} - {_desc}";
    }

    public override string SaveString()
    {
        return $"Simple|{_name}|{_desc}|{_points}|{_done}";
    }
}
