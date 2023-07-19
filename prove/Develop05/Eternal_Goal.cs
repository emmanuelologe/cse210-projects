public class EternalGoal : Goal
{
    private int _pointsPerRecord;

    public EternalGoal(string name, string description, int pointsPerRecord, bool isCompleted) : base(name, description, isCompleted)
    {
        _pointsPerRecord = pointsPerRecord;
    }

    public override int GetPointsEarned() => _isCompleted ? _pointsPerRecord : 0;
    public override void DisplayGoalStatus() => Console.WriteLine($"[{(_isCompleted ? "X" : " ")}] {_name} - {_description}");
}