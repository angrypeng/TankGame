using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class csEnemyTower : MonoBehaviour {

	Transform obj = null;

	// Use this for initialization
	void Start () {
		obj = GameObject.Find("MyTurret").transform;
	}
	
	// Update is called once per frame
	void Update () {
		transform.LookAt(obj);
	}
}
