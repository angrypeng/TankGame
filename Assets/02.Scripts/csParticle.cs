using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class csParticle : MonoBehaviour {
	public GameObject particle;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void Hi(Transform spawn){
		GameObject particleObj = Instantiate (particle) as GameObject;
		particleObj.transform.position = spawn.position;
		Destroy (particleObj, 1.0f);
	}
}
