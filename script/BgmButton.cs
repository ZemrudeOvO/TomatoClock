using Godot;
using System;

public partial class BgmButton : CheckButton
{
    AudioStreamPlayer bgm;
    float position;

    HSlider volume;
    CheckBox mute;

    public override void _Ready()
    {
        bgm = GetNode<AudioStreamPlayer>("BGM");
        volume = GetNode<HSlider>("Volume");
        mute = GetNode<CheckBox>("Mute");

        this.Connect("toggled", new Callable(this, "ButtonToggled"));
        volume.ValueChanged += (value) => AudioServer.SetBusVolumeDb(1, (float)Mathf.LinearToDb(value));
        mute.Toggled += (pressed) => AudioServer.SetBusMute(1, pressed);
    }

    void ButtonToggled(bool isToggled)
    {
        if (isToggled)
        {
            bgm.Play(position);
        }
        else
        {
            bgm.StreamPaused = true;
            position = bgm.GetPlaybackPosition();
        }
    }
}
