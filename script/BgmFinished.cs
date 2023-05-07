using Godot;
using System;

public partial class BgmFinished : AudioStreamPlayer
{
    public override void _Ready()
    {
        this.Finished += PlayNextSong;
    }

    void PlayNextSong()
    {
    }
}
