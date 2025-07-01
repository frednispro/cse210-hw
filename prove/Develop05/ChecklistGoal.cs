class ChecklistGoal : Goal
{
    private int _target;
    private int _count;
    private int _bonus;

    public ChecklistGoal(string name, string desc, int points, int target, int bonus, int count = 0)
        : base(name, desc, points)
    {
        _target = target;
        _bonus = bonus;
        _count = count;
    }

    public override int RecordEvent()
    {
        if (_count < _target)
        {
            _count++;
            if (_count == _target)
                return _points + _bonus;
            return _points;
        }
        return 0;
    }

    public override string GetStatus()
    {
        string done = _count >= _target ? "X" : " ";
        return $"[{done}] {_name} - {_desc} ({_count}/{_target})";
    }

    public override string SaveString()
    {
        return $"Checklist|{_name}|{_desc}|{_points}|{_target}|{_bonus}|{_count}";
    }
}
