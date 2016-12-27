using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class csCannon : MonoBehaviour {
	Transform firePos;
	float power = 900.0f;
	public GameObject particle;
	// Use this for initialization
	void Start () {
		//transform.Rotate (90.0f, 0.0f, 0.0f);
		firePos = GameObject.Find("/MyTurret/Tower/mySpawnPoint").transform;
		GetComponent<Rigidbody> ().AddForce (firePos.forward * power);
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		if (this.transform.position.y < 0.5f) {
			GameObject tmp =  Instantiate (particle, this.transform.position, this.transform.rotation) as GameObject;
			Destroy (tmp, 0.2f);
			Destroy (this.gameObject);	
		}
	}

	void OnTriggerEnter(Collider coll){
		GameObject tmp =  Instantiate (particle, this.transform.position, this.transform.rotation) as GameObject;
		Destroy (tmp, 0.2f);
		Destroy (this.gameObject);
	}

}
