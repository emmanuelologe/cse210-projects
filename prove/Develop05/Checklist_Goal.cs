public class ChecklistGoal : Goal
{
    private int _pointsPerRecord;
    private int _requiredTimes;
    private int _timesCompleted;

    public ChecklistGoal(string name, string description, int pointsPerRecord, int requiredTimes, bool isCompleted) : base(name, description, isCompleted)
    {
        _pointsPerRecord = pointsPerRecord;
        _requiredTimes = requiredTimes;
        _timesCompleted = 0;
    }

    public override int GetPointsEarned()
    {
        if (!_isCompleted) return 0;
        return (_pointsPerRecord * _timesCompleted) + (IsBonusAchieved() ? GetBonusPoints() : 0);
    }

    public override void MarkCompleted()
    {
        _timesCompleted++;
        base.MarkCompleted();
    }

    private bool IsBonusAchieved() => _timesCompleted >= _requiredTimes;
    private int GetBonusPoints() => 500; // Example bonus points, you can adjust this as needed.

    public override void DisplayGoalStatus()
    {
        if (_isCompleted)
            Console.WriteLine($"Completed {_timesCompleted}/{_requiredTimes} times - {_name} - {_description}");
        else
            Console.WriteLine($"[ ] {_name} - {_description}");
    }
}