using Godot;
using System;

public partial class ButtonPressedStartClock : Button
{
    [Export]
    public Timer work;
    [Export]
    public SpinBox spinBox;
    [Export]
    public Button restartButton;

    public override void _Ready()
    {
        this.Pressed += () => work.WaitTime = Status.WorkTime;
        this.Pressed += () => work.Start();
        this.Pressed += () => this.Disabled = true;
        this.Pressed += () => restartButton.Disabled = false;
    }
}
