public class SimpleGoal : Goal
{
    private int _points;

    public SimpleGoal(string name, string description, int points) : base(name, description)
    {
        _points = points;
    }

    public override int GetPointsEarned()
    {
        return _isCompleted ? _points : 0;
    }

    public override void DisplayGoalStatus()
    {
        Console.WriteLine($"[{(_isCompleted ? "X" : " ")}] {_name} - {_description}");
    }
}