using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveSphere : MonoBehaviour
{

	// Use this for initialization
	void Start ()
	{
		
	}
	
	// Update is called once per frame
	void Update ()
	{
		transform.position += new Vector3 (0f, 0f, -0.02f);//the z axis of whatever this script is attached to moves -0.02 constantly
		if (Input.GetKey (KeyCode.W)) 
		{
			transform.position += new Vector3 (0f, 0f, -0.1f);
		} 
		else 
		{
			transform.position += new Vector3 (0f, 0f, -0.02f);
		}



	}
}
