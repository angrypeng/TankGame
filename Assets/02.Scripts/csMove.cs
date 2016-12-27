using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class csMove : MonoBehaviour {

	float rotSpeed = 120.0f;
	float movSpeed = 5.0f;
	
	// Update is called once per frame
	void Update () {
		float amtMove = movSpeed * Time.deltaTime;
		float amtRot= rotSpeed* Time.deltaTime;

		float ang = Input.GetAxis ("Horizontal");
		float ver = Input.GetAxis ("Vertical");

		transform.Rotate (Vector3.up* ang*amtRot);
		transform.Translate (Vector3.forward* ver*amtMove);
		
	}
}
