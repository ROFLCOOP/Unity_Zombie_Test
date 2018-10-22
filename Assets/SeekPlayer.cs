using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SeekPlayer : MonoBehaviour {

	private GameObject	Player;
	private Vector3		TargetPoint;
	private Quaternion	TargetRotation;
	//[Range(0.0f, 360.0f)]
	public	float		rotateSpeed		= 1.0f;
	//[Range(0.0f, 100.0f)]
	public	float		walkSpeed		= 1.0f;
	
	void Start () {
		Player = GameObject.Find("Player");
		Debug.Assert(Player);
	}
	
	void Update () {

		TargetPoint = Player.transform.position - transform.position;
		TargetRotation = Quaternion.LookRotation(TargetPoint, Vector3.up);

		transform.rotation = Quaternion.Slerp(transform.rotation, TargetRotation, Time.deltaTime * rotateSpeed);
		if(TargetPoint.magnitude > 10.0f)
		{
			transform.Translate(Vector3.forward * walkSpeed * Time.deltaTime);
		}
		//transform.rotation = rotate;
	}
}
