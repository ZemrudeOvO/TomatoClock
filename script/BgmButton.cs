using Godot;
using System;

public partial class BgmButton : CheckButton
{
    AudioStreamPlayer bgm;

    public override void _Ready()
    {
        bgm = GetNode<AudioStreamPlayer>("BGM");

        this.Connect("toggled", new Callable(this, "ButtonToggled"));
    }

    void ButtonToggled(bool isToggled)
    {
        if (isToggled)
            bgm.Play(0);
        else
            bgm.Stop();
    }
}
