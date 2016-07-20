using UnityEngine;
using System.Collections;

public class MeteorBehavior : MonoBehaviour {

	//float rand = Random.value % 4;


	// Use this for initialization
	void Start () {
		//Renderer rend = GetComponent<Renderer>();
		//rend.material.shader = Shader.Find("Specular");
		//rend.material.SetColor ("_SpecColor", Color.red);
//		if (rand == 1)
//			rend.material.SetColor ("_SpecColor", Color.red);
//		else if (rand == 2)
//			rend.material.SetColor ("_SpecColor", Color.blue);
//		else if (rand == 3)
//			rend.material.SetColor ("_SpecColor", Color.green);
//		else 
//			rend.material.SetColor ("_SpecColor", Color.yellow);
	}
	
	// Update is called once per frame
	void Update () {
		Vector3 pos = transform.position;
		//Debug.Log (pos);
		transform.Translate (-pos * (Time.deltaTime/3), Camera.main.transform);
	}

	// Registers collision, but does not "collide" with maincirle 
	void OnCollisionEnter2D(Collision2D coll) {
		Debug.Log ("OH COLLISION");
//		var joint = gameObject.AddComponent<FixedJoint2D>();
//		joint.connectedBody = coll.rigidbody;

	}
}
