using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class csEnemyTower : MonoBehaviour {

	Transform obj = null;
	public GameObject particle;
	public GameObject enemyCannon;
	public Transform enemyFirePos;
	float time;

	// Use this for initialization
	void Start () {
		obj = GameObject.Find("MyTurret").transform;
		time = 0.0f;
	}
	
	// Update is called once per frame
	void Update () {
		transform.LookAt(obj);
		if (time >= 1.0f) {
			Instantiate (enemyCannon, 
				enemyFirePos.position,
				Quaternion.identity);
			GameObject tmpParticle =  Instantiate (particle, enemyFirePos.position, enemyFirePos.rotation) as GameObject;
			Destroy (tmpParticle, 0.8f);
			time = 0.0f;
		}
	}

	void FixedUpdate(){
		float dis = Vector3.Distance (
			obj.transform.position, 
			this.transform.position);
		if (dis < 20.0f) {
			time += Time.deltaTime;
			//Debug.Log (time);
			if (time >= 1.0f) {
				//time = 0.0f;
			}
		}
	}
		
}
