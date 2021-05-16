using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bottomRightChild : MonoBehaviour {
	public Vector3 movement;
	public float timer;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		timer += Time.deltaTime;
		GetComponent <Transform> ().Translate (movement);
		if (timer >= 3.5) {
			movement.x = movement.x * 2;
			movement.y = movement.y * 2;
			timer = 0;
		}
		
	}
}
