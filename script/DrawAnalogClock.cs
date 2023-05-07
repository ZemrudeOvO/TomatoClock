using Godot;
using System;

public partial class DrawAnalogClock : Control
{
    [Export(PropertyHint.Range, "0,1280,1")]
    public Vector2 circlePosition = new Vector2(1265, 12);
    [Export(PropertyHint.Range, "0,10,")]
    public uint radius = 10;
    [Export(PropertyHint.Range, "0,10,")]
    public uint width = 1;

    public override void _Process(double delta)
    {
    }
}
