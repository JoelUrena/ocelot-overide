using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class swirlScript : MonoBehaviour {
	public Vector3 movementSwirl;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		GetComponent<Transform> ().Rotate (movementSwirl);
	}
}
