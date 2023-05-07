using Godot;
using System;

public partial class RestartTimer : Button
{
    [Export]
    Timer timer;

    public override void _Ready()
    {
        this.Disabled = true;
        this.Pressed += () => timer.WaitTime = Status.WorkTime;
        this.Pressed += () => timer.Start();
    }
}
