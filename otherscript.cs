using Godot;
using System;
using System.Runtime.InteropServices;

public class otherscript : Node2D
{
    // Declare member variables here. Examples:
    // private int a = 2;
    // private string b = "text";
    private string _stateName = "walk";

    // Called when the node enters the scene tree for the first time.
    public override void _Ready()
    {
        
    }
    public string OtherTestName{get; private set;} = "testtesttest";
    public string StateName{
        get => _stateName;
        set{
         _stateName = value;   
        }
    }
    public bool IsGrounded => _stateName != "Jump";
//  public override void _Process(float delta)
//  {
//      
//  }
}
