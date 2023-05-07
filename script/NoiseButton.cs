using Godot;
using System;

public partial class NoiseButton : CheckButton
{
    AudioStreamPlayer noise;
    float position;

    HSlider volume;
    CheckBox mute;

    public override void _Ready()
    {
        noise = GetNode<AudioStreamPlayer>("Noise");
        volume = GetNode<HSlider>("Volume");
        mute = GetNode<CheckBox>("Mute");

        this.Connect("toggled", new Callable(this, "ButtonToggled"));
        volume.ValueChanged += (value) => AudioServer.SetBusVolumeDb(2, (float)Mathf.LinearToDb(value));
        mute.Toggled += (pressed) => AudioServer.SetBusMute(2, pressed);
    }

    void ButtonToggled(bool isToggled)
    {
        if (isToggled)
        {
            noise.Play(position);
        }
        else
        {
            noise.StreamPaused = true;
            position = noise.GetPlaybackPosition();
        }
    }
}
