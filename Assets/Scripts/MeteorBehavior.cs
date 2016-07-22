using UnityEngine;
using System.Collections;

public class MeteorBehavior : MonoBehaviour {

	float ran;
	float count = 0;
	bool shouldMove = true; 


	// Use this for initialization
	void Start () {
		//Renderer rend = GetComponent<Renderer>();
		//rend.material.SetColor ("_SpecColor", Color.red);
		ran = Random.Range (1,5);
		if (ran == 1) {
			gameObject.GetComponent<Renderer> ().material.color = Color.green;
			gameObject.tag = "green"; 
		} else if (ran == 2) {
			gameObject.GetComponent<Renderer> ().material.color = Color.red;
			gameObject.tag = "red";
		} else if (ran == 3) {
			gameObject.GetComponent<Renderer> ().material.color = Color.cyan;
			gameObject.tag = "cyan";
		} else {
			gameObject.GetComponent<Renderer> ().material.color = Color.magenta;
			gameObject.tag = "magenta"; 
		}

		//var joint = gameObject.AddComponent<FixedJoint2D>();
	}
	
	// Update is called once per frame
	void Update () {
		if (shouldMove) {
			Vector3 pos = transform.position;
			//Debug.Log (pos);
			transform.Translate (-pos * (Time.deltaTime), Camera.main.transform); // denominator controls speed
		}
	}

	void OnCollisionEnter2D(Collision2D coll) { 

		if (coll.transform.name == "Circle")
			shouldMove = false; 

		if (this.tag == coll.gameObject.tag) { //vcoll.transform.name == "MeteorPrefab(Clone)" && 
			count++;
			Debug.Log (count);

			//if (count >= 3) {
				//Destroy (this.gameObject);
				//Destroy (coll.gameObject);
			//}
		}

		var joint = gameObject.AddComponent<FixedJoint2D>();
		joint.connectedBody = coll.rigidbody;

	}

}
