﻿using UnityEngine;
using System.Collections;

public class RotateCircle : MonoBehaviour {

	void Start() {

	}

	// Update is called once per frame
	void Update () {
		if (Input.GetKey (KeyCode.LeftArrow)) {
			//transform.Rotate (Vector3.forward, (Time.deltaTime * 200));
			transform.Rotate(Vector3.forward, (Time.deltaTime * 200), Space.World );
			//Debug.Log ("Left key was pressed.");
			//Debug.Log (Time.deltaTime);
		}
			
		if (Input.GetKey (KeyCode.RightArrow)) {
			transform.Rotate(Vector3.forward, (Time.deltaTime * -200), Space.World );
			//Debug.Log ("Right key was pressed.");

		}
	}
}