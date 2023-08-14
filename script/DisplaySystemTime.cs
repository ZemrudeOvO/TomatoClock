using Godot;
using System;

public partial class DisplaySystemTime : Label
{
    public override void _Process(double delta)
    {
        this.Text = Time.GetTimeStringFromSystem();
        Vector2 vec = new Vector2(0, 0);
    }
}
