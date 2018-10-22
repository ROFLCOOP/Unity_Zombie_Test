using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class PropelOnStart : MonoBehaviour {

	[Range(0.0f, 1000.0f)]
	public float ForceAmount = 1000.0f;

	//Time CreationTime;

	// Use this for initialization
	void Start () {
		

		GetComponent<Rigidbody>().AddForce(transform.forward * ForceAmount, ForceMode.VelocityChange);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
