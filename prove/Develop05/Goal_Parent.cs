using System;
using System.Collections.Generic;

public abstract class Goal
{
    protected string _name;
    protected string _description;
    protected bool _isCompleted;

    public string Name => _name;
    public string Description => _description;
    public bool IsCompleted => _isCompleted;

    public Goal(string name, string description)
    {
        _name = name;
        _description = description;
        _isCompleted = false;
    }

    public abstract int GetPointsEarned();

    public virtual void MarkCompleted()
    {
        _isCompleted = true;
    }

    public abstract void DisplayGoalStatus();
}