using UnityEngine;
using System.Collections;

public class SpawnMeteors : MonoBehaviour {

	public GameObject meteorPrefab;
	
	// Borders
	public Transform borderTop;
	public Transform borderBottom;
	public Transform borderLeft;
	public Transform borderRight;

	// Use this for initialization
	void Start () {
		InvokeRepeating ("Spawn", 2, 2);
	}
	
	// Update is called once per frame
	void Update () {
		// Spawn meteor every 4 seconds, starting in 3
		//InvokeRepeating("Spawn", 3, 4);
	}

	// Spawn one piece of food
	void Spawn() {
		//Debug.Log ("spawned");
		// x position between left & right border
		int x = (int)Random.Range (borderLeft.position.x,
			        borderRight.position.x);

		// y position between top & bottom border
		int y = (int)Random.Range (borderBottom.position.y,
			        borderTop.position.y);

		// Instantiate the food at (x, y)
		Vector2 start1 = new Vector2 (borderLeft.position.x, y);
		Vector2 start2 = new Vector2 (x, borderTop.position.y);
		Vector2 start3 = new Vector2 (borderRight.position.x, y);
		Vector2 start4 = new Vector2 (x, borderBottom.position.y);

		float ran = Random.Range (1, 5);
		if ( ran == 1 )
			Instantiate (meteorPrefab, start1, Quaternion.identity); // default rotation
		else if ( ran == 2 )
			Instantiate (meteorPrefab, start2, Quaternion.identity);
		else if ( ran == 3 )
			Instantiate (meteorPrefab, start3, Quaternion.identity);
		else
			Instantiate (meteorPrefab, start4, Quaternion.identity); 
	}
}
