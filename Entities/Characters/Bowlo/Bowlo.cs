using Godot;
using System;
using System.Diagnostics;

public partial class Bowlo : Node3D
{
	[Export]
	public float velocity {get; set;} = 0.0f;

	[Export]
	public string currentMode {get; set;} = "bowl"; 
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
		GD.Print("Hello, Im Bowlo");
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
		BowlingAlley BowlingAlley = GetNode<BowlingAlley>("../BowlingAlley");
		float bowlingAlleyPlayableWidth = BowlingAlley.playableWidth;
		float bowlingAlleyPlayableLength = BowlingAlley.playableLength;

		var velocity = Vector3.Zero;

		if (Input.IsActionPressed("moveRight"))
		{
			velocity.X += 5;

		}

		if (Input.IsActionPressed("moveLeft"))
		{
			velocity.X -= 5;
		}

		if (Input.IsActionPressed("moveForward"))
		{
			velocity.Z -= 5;
		}

		if (Input.IsActionPressed("moveBack"))
		{
			velocity.Z += 5;
		}
		Position += velocity * (float)delta;
		Position = new Vector3(
			x: Mathf.Clamp(Position.X, 0, bowlingAlleyPlayableWidth),
			y: 1,
			z: Mathf.Clamp(Position.Z, 0, bowlingAlleyPlayableLength)
		);
	}
}
