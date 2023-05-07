using Godot;
using System;

public partial class SpinBoxInstantChangeWorkTime : SpinBox
{
    [Export]
    public Timer timer;

    public override void _Ready()
    {
        this.ValueChanged += (value) => Status.WorkTime = (int)value;
    }
}
