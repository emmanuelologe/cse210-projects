public class ChecklistGoal : Goal
{
    private int _pointsPerRecord;
    private int _requiredTimes;
    private int _timesCompleted;

    public ChecklistGoal(string name, string description, int pointsPerRecord, int requiredTimes) : base(name, description)
    {
        _pointsPerRecord = pointsPerRecord;
        _requiredTimes = requiredTimes;
        _timesCompleted = 0;
    }

    public override int GetPointsEarned()
    {
        return _isCompleted ? (_pointsPerRecord * _timesCompleted) + (IsBonusAchieved() ? GetBonusPoints() : 0) : 0;
    }

    public override void MarkCompleted()
    {
        _timesCompleted++;
        base.MarkCompleted();
    }

    private bool IsBonusAchieved()
    {
        return _timesCompleted >= _requiredTimes;
    }

    private int GetBonusPoints()
    {
        return 500; // Example bonus points, you can adjust this as needed.
    }

    public override void DisplayGoalStatus()
    {
        if (_isCompleted)
        {
            Console.WriteLine($"Completed {_timesCompleted}/{_requiredTimes} times - {_name} - {_description}");
        }
        else
        {
            Console.WriteLine($"[ ] {_name} - {_description}");
        }
    }
}