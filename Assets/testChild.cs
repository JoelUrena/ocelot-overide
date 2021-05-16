using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class testChild : MonoBehaviour {
	public Vector3 scale;
	public float timer;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		timer += Time.deltaTime;
		transform.localScale += (scale);
		if (timer >= 3.5) 
		{
			scale.x = scale.x * 2;
			scale.y = scale.y * 2;
			timer = 0;
		}
	}
}
//the problem with putting all values in a child is that the object arent moving