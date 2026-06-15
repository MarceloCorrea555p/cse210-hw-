using System;

public class ChecklistGoal : Goal
{
    private int _amountCompleted;
    private int _target;
    private int _bonus;

    public int Bonus => _bonus;

    // Constructor estándar
    public ChecklistGoal(string shortName, string description, int points, int target, int bonus) 
        : base(shortName, description, points)
    {
        _amountCompleted = 0;
        _target = target;
        _bonus = bonus;
    }

    // Constructor especial para la carga de archivos
    public ChecklistGoal(string shortName, string description, int points, int amountCompleted, int target, int bonus) 
        : base(shortName, description, points)
    {
        _amountCompleted = amountCompleted;
        _target = target;
        _bonus = bonus;
    }

    public override void RecordEvent()
    {
        if (_amountCompleted < _target)
        {
            _amountCompleted++;
            Console.WriteLine($"You have recorded an event for the goal: {_shortName} and earned {_points} points!");
            
            if (_amountCompleted == _target)
            {
                Console.WriteLine($"Congratulations! You have fully completed the goal: {_shortName} and earned an additional bonus of {_bonus} points!");
            }
        }
        else
        {
            Console.WriteLine($"The goal: {_shortName} has already been completed.");
        }
    }

    public override bool IsComplete()
    {
        return _amountCompleted >= _target;
    }

    public override string GetDetailsString()
    {
        string statusSign = IsComplete() ? "[X]" : "[ ]";
        return $"{statusSign} {_shortName} ({_description}) -- Currently completed: {_amountCompleted}/{_target}";
    }

    public override string GetStringRepresentation()
    {
        return $"ChecklistGoal:{_shortName}|{_description}|{_points}|{_amountCompleted}|{_target}|{_bonus}";
    }
}
