using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class logoRotate : MonoBehaviour {
	public Vector3 freefallR;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		GetComponent<Transform> ().Rotate (freefallR);


	}
}
