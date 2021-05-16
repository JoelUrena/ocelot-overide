using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bottomLeft : MonoBehaviour {
	public Vector3 movement;
	public Vector3 scale;
	public float timer;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		timer += Time.deltaTime;
		GetComponent <Transform> ().Translate (movement);
		transform.localScale += (scale);
		if (timer >= 3.5) 
		{
			movement.x = movement.x * 3;
			movement.y = movement.y * 3;
			scale.x = scale.x * 3;
			scale.y = scale.y * 3;
			timer = 0;
		}
	}
}
