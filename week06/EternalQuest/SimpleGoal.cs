using System;

public class SimpleGoal : Goal
{
    private bool _isComplete;

    
    public SimpleGoal(string shortName, string description, int points) 
        : base(shortName, description, points)
    {
        _isComplete = false;
    }

    
    public SimpleGoal(string shortName, string description, int points, bool isComplete) 
        : base(shortName, description, points)
    {
        _isComplete = isComplete;
    }

    public override void RecordEvent()
    {
        if (!_isComplete)
        {
            _isComplete = true;
            Console.WriteLine($"You have recorded an event for the goal: {_shortName} and earned {_points} points!");
        }
        else
        {
            Console.WriteLine($"The goal: {_shortName} has already been completed.");
        }
    }

    public override bool IsComplete()
    {
        return _isComplete;
    }

    public override string GetStringRepresentation()
    {
        return $"SimpleGoal:{_shortName}|{_description}|{_points}|{_isComplete}";
    }
}
