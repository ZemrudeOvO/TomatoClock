using Godot;
using System;

public partial class NoiseFinished : AudioStreamPlayer
{
    public override void _Ready()
    {
        this.Finished += () => this.Play(0);
    }
}
