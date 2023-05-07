using Godot;
using System;

public partial class TimeCounter : Timer
{
    [Export]
    public AudioStreamPlayer audioStreamPlayer;
    [Export]
    public Button startButton;
    [Export]
    public Button restartButton;

    public override void _Ready()
    {
        this.WaitTime = Status.WorkTime;
        this.Timeout += () => audioStreamPlayer.Play(0);
        this.Timeout += () => startButton.Disabled = false;
        this.Timeout += () => restartButton.Disabled = true;
        this.Timeout += () => OS.Alert("Tomato", "Tomato clock time out!");
    }
}