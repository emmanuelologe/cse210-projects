public class SimpleGoal : Goal
{
    private int _points;

    public SimpleGoal(string name, string description, int points, bool isCompleted) : base(name, description, isCompleted)
    {
        _points = points;
    }

    public override int GetPointsEarned() => _isCompleted ? _points : 0;
    public override void DisplayGoalStatus() => Console.WriteLine($"[{(_isCompleted ? "X" : " ")}] {_name} - {_description}");
}