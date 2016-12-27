using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class csMyTower : MonoBehaviour {

	float rotSpeed = 120.0f;

	// Update is called once per frame
	void Update () {
		float amtRot= rotSpeed* Time.deltaTime;

		float ang = Input.GetAxis ("Turret");

		transform.Rotate (Vector3.up* ang*amtRot);

	}
}
