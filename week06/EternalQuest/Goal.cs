using System;

public abstract class Goal
{
    protected string _shortName;
    protected string _description;
    protected int _points;

    // Propiedad pública para que GoalManager pueda leer los puntos limpiamente
    public int Points => _points;

    public Goal(string shortName, string description, int points)
    {
        _shortName = shortName;
        _description = description;
        _points = points;
    }

    public abstract void RecordEvent();
    public abstract bool IsComplete();
    
    public virtual string GetDetailsString()
    {
        string statusSign = IsComplete() ? "[X]" : "[ ]";
        return $"{statusSign} {_shortName} ({_description})";
    }

    public abstract string GetStringRepresentation();
}
