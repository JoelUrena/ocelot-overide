using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class doomEnemy : MonoBehaviour {
	public Vector3 movementDoom;
	//public float timer;
	// Use this for initialization
	void Start () {
		//timer = -20;//the timer starts at negative 20
	}
	
	// Update is called once per frame
	void Update () {
//		if(transform.position.z > timer)//if the z axis postition is grter than the timer
//		{
	//		timer += Time.deltaTime;//then the timer is equal to what ever time is, plus delt time (seconds)
			//GetComponent <Transform> ().Translate (movementDoom);//also, moves vector3 "movement doom"
		transform.Translate(movementDoom);
//			if (timer >= Random.Range(-19.5f,25f)) //if the time is equal or gretater than to 
//			{
//				timer = 10000;
//				Debug.Log ("helloworld");
//			}
//		}
		/*if ()
		GetComponent <Transform> ().Translate (movementDoom);*/
	}
}
