using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class csMainScript : MonoBehaviour {
	public Transform firePos;
	public GameObject cannon;
	public Transform particleSpawn;

	// Use this for initialization
	void Start () {
		
	}

	// Update is called once per frame
	void Update () {
		if (Input.GetButtonDown ("Fire1")) {
			Instantiate (cannon, 
				firePos.position,
				Quaternion.identity);
			DoMyParticle ();
		}
	}

	void DoMyParticle(){
		csParticle particleScript = this.transform.GetComponent<csParticle> ();
		particleScript.Hi (particleSpawn);
	}
}
