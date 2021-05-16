using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveSphere : MonoBehaviour
{
	public wallScript wallScript;
	public float privTimer;

	// Use this for initialization
	void Start ()
	{
		privTimer = 2f;
	}
	
	// Update is called once per frame
	void Update ()
	{
		//transform.position += new Vector3 (0f, 0f, -0.05f);//the z axis of whatever this script is attached to moves -0.02 constantly
		

		//if (Input.GetKey (KeyCode.W)) 
		//{
		//	fast();
		//} 
		//if (wallScript.jiggy == false)
		//{
		//	slow();
		//}
		//else
       // {
		//	slower();
       // }

		if (wallScript.jiggy == true)
        {
			slower();
        }
        else
        {
			slow();
        }



	}
	public void fast()
	{
		transform.position += new Vector3(0f, 0f, -0.4f);
	}
	public void slow()
	{
		transform.position += new Vector3(0f, 0f, -0.1f);//the z axis of whatever this script is attached to moves -0.02 constantly
	}
	public void slower()
	{
		privTimer +=  (Time.deltaTime/30f);//timer starts when function summoned
		transform.position += new Vector3(0f, 0f, 1 * (Mathf.Pow((-0.04f * (privTimer - 0.02f)), 1)));//the z axis of whatever this script is attached to moves -0.02 constantly, also being grown by constant exponential growth formula. 
		//Multiplied exponential growth formula by -1
		
	}
}
