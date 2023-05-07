using Godot;
using System;

public partial class DisplayWorkAndRestTIme : Label
{
    [Export]
    public Timer work;

    public int leftValue, rightValue;

    public override void _Ready()
    {
    }

    public override void _Process(double delta)
    {
        this.Text = $"{(int)work.TimeLeft}/{Status.WorkTime}";
    }
}
