using Godot;
using System;

public partial class NoiseButton : CheckButton
{
    AudioStreamPlayer noise;

    public override void _Ready()
    {
        noise = GetNode<AudioStreamPlayer>("Noise");

        this.Connect("toggled", new Callable(this, "ButtonToggled"));
    }

    void ButtonToggled(bool isToggled)
    {
        if (isToggled)
            noise.Play(0);
        else
            noise.Stop();
    }
}
