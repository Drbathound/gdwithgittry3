using Godot;
using System;

public class MainGame : Node
{
	// Declare member variables here. Examples:
	// private int a = 2;
	// private string b = "text";
	Random random = new Random();
	string _enemyName = "test";
	otherscript myother = new otherscript();
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
		GD.Print("Hello World");
		GD.Print(EnemyName);
		GD.Print(TestName);
		TestName = "new name";
		GD.Print(TestName);
		GD.Print(myother.OtherTestName);
		GD.Print(myother.IsGrounded);
		GD.Print(myother.StateName);
		myother.StateName = "Jump";
		GD.Print(myother.IsGrounded);
		GD.Print(myother.StateName);
	}

//  // Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(float delta)
	{
		
	}

	public string EnemyName{
		get{
			return _enemyName;
		}
		set{
			_enemyName = value;
		}
	}
	public string TestName{get; set;} = "test";
}
