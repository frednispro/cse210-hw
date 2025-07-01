class EternalGoal : Goal
{
    public EternalGoal(string name, string desc, int points)
        : base(name, desc, points) { }

    public override int RecordEvent() => _points;

    public override string GetStatus() => $"[∞] {_name} - {_desc}";

    public override string SaveString() => $"Eternal|{_name}|{_desc}|{_points}";
}
