using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class csMainScript : MonoBehaviour {
	public Transform firePos;
	public GameObject cannon;
	private Quaternion rot;

	float power = 900.0f;

	// Use this for initialization
	void Start () {
		rot = Quaternion.Euler (90.0f, 0.0f, 0.0f);
	}

	// Update is called once per frame
	void Update () {
		if (Input.GetButtonDown ("Fire1")) {
			GameObject obj = Instantiate (cannon, 
				firePos.position,
				firePos.rotation) as GameObject;
			obj.GetComponent<Rigidbody> ().AddForce (firePos.forward * power);
		}
	}
}
