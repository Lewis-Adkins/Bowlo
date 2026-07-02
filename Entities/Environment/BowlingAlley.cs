using Godot;
using System;

public partial class BowlingAlley : Node3D
{
	[Export]
	public float playableWidth {get; set;} = 10;

	[Export]
	public float playableLength {get; set;} = 10;

	public static  string TestFunc(string aTest)
	{
		return aTest;
	}
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
	}
}
