using Godot;
using System;

// In here we put level-specific properties and functions. All other levels' scripts should inherit from this
public class Level : Node
{
    [Export]
    string levelName = "Unnamed level";

    // Called when the node enters the scene tree for the first time.
    // Override this in other level scripts and call "._Ready()" in their _Ready().
    public override void _Ready()
    {
        GD.Print("Initializing '" + levelName + "'...");
        InitLevel();
        GD.Print("Initializing '" + levelName + "'... DONE");
    }

    // Override this in your level scripts and do your initialization there so if you print stuff related to initialization it stays between the initialization prints from _Ready().
    public virtual void InitLevel()
    {
        // Do stuff
    }

    // Called every frame. 'delta' is the elapsed time since the previous frame.
    // public override void _Process(float delta)
    // {
        
    // }
}
