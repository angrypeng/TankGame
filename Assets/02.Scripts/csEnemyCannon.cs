using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class csEnemyCannon : MonoBehaviour {

	Transform eFirePos;
	public float ePower;
	public GameObject particle;

	// Use this for initialization
	void Start () {
		//transform.Rotate (90.0f, 0.0f, 0.0f);
		eFirePos = GameObject.Find("/Enemy/EnemyTurret/Tower/spawnPoint").transform;
		GetComponent<Rigidbody> ().AddForce (eFirePos.forward * ePower);
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
