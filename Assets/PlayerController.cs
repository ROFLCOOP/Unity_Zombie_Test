using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

	[Tooltip("This will affect the speed of the player")]
	[Range(0, 100)]
	public float Speed = 50.0f;

	[Range(0.0f, 360.0f)]
	public float TurnSpeed = 360.0f;

	public GameObject BulletPrefab;

	private Transform fireLocation;

	// Use this for initialization
	void Start ()
	{
		fireLocation = transform.Find("FirePoint");
		Debug.Assert(fireLocation);
	}

	// Update is called once per frame
	void Update() {
		if (Input.GetKey(KeyCode.W))
			transform.Translate(Vector3.forward * Speed * Time.deltaTime);

		if (Input.GetKey(KeyCode.S))
			transform.Translate(Vector3.back * Speed * Time.deltaTime);

		if (Input.GetKey(KeyCode.A))
			transform.Translate(Vector3.left * Speed * Time.deltaTime);

		if (Input.GetKey(KeyCode.D))
			transform.Translate(Vector3.right * Speed * Time.deltaTime);

		if (Input.GetKey(KeyCode.LeftArrow))
		{
			Quaternion rotate = Quaternion.AngleAxis(-TurnSpeed * Time.deltaTime, Vector3.up);
			transform.rotation *= rotate;
		}

		if (Input.GetKey(KeyCode.RightArrow))
		{
			Quaternion rotate = Quaternion.AngleAxis(TurnSpeed * Time.deltaTime, Vector3.up);
			transform.rotation *= rotate;
		}

		if (Input.GetKeyDown(KeyCode.Space))
		{
			//Transform fireLocation = transform.Find("ShutObj");
			//Debug.Assert(fireLocation);

			GameObject newObject = Instantiate(BulletPrefab,
				fireLocation.position,
				fireLocation.rotation);
		}
		//if (Input.GetKey(KeyCode.UpArrow))
		//{
		//	Quaternion rotate = Quaternion.AngleAxis(-TurnSpeed * Time.deltaTime, Vector3.up);
		//	transform.rotation *= rotate;
		//}
		//
		//if (Input.GetKey(KeyCode.DownArrow))
		//{
		//	Quaternion rotate = Quaternion.AngleAxis(TurnSpeed * Time.deltaTime, Vector3.up);
		//	transform.rotation *= rotate;
		//}
	}
}
