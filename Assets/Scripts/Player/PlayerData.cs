using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Player/Player Data")]
public class PlayerData : ScriptableObject
{
	[Header("Gravity")]
	public float gravityScale;
	public float fallGravityMult;
	public float quickFallGravityMult;

	[Header("Drag")]
	public float dragAmount; 
	public float frictionAmount; 

	[Header("Other Physics")]
	[Range(0, 0.5f)] public float coyoteTime; 
 
	[Header("Run")]
	public float runMaxSpeed;
	public float runAccel;
	public float runDeccel;
	public float speedUp;
	[Range(0, 1)] public float accelInAir;
	[Range(0, 1)] public float deccelInAir;
	[Space(5)]
	[Range(.5f, 2f)] public float accelPower;   
	[Range(.5f, 2f)] public float stopPower;
	[Range(.5f, 2f)] public float turnPower;

	[Header("Jump")]
	public float jumpForce;
	[Range(0, 1)] public float jumpCutMultiplier;
	[Space(10)]
	[Range(0, 0.5f)] public float jumpBufferTime; 
 
	[Header("Wall Jump")]
	public Vector2 wallJumpForce;
	[Space(5)]
	[Range(0f, 1f)] public float wallJumpRunLerp; 
	[Range(0f, 1.5f)] public float wallJumpTime;

	[Header("Slide")]
	public float slideAccel;
	[Range(.5f, 2f)] public float slidePower;

	[Header("Dash")]
	public int dashAmount;
	public float dashSpeed;
	[Space(5)]
	public float dashAttackTime;
	public float dashAttackDragAmount;
	[Space(5)]
	public float dashEndTime;
	[Range(0f, 1f)] public float dashUpEndMult;
	[Range(0f, 1f)] public float dashEndRunLerp;
	[Space(5)]
	[Range(0, 0.5f)] public float dashBufferTime;

	[Header("Other Settings")]
	public bool doKeepRunMomentum;
	public bool doTurnOnWallJump;
	public float height;
}
