using Godot;
using System;

public partial class AnalogClock : Node2D
{
    Sprite2D Minut;
    Sprite2D Hour;

    public override void _Ready()
    {
        Minut = GetNode<Sprite2D>("Minute");
        Hour = GetNode<Sprite2D>("Hour");
    }

    public override void _Process(double delta)
    {
        Minut.RotationDegrees = (float)Time.GetTimeDictFromSystem()["minute"] / 60 * 360;
        Hour.RotationDegrees = (float)Time.GetTimeDictFromSystem()["hour"] % 12 / 12 * 360;
    }
}
