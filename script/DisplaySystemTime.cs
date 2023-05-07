using Godot;
using System;

public partial class DisplaySystemTime : Label
{
    public override void _Process(double delta)
    {
        this.Text = Time.GetTimeStringFromSystem();
    }
}
