using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class csRotateAround : MonoBehaviour {
	Transform obj = null;

	// Use this for initialization
	void Start () {
		obj = GameObject.Find ("rotationPoint").transform;
	}
	
	// Update is called once per frame
	void Update () {
		transform.RotateAround (obj.position, Vector3.up, 40 * Time.deltaTime);
		transform.LookAt (obj);
	}
}
