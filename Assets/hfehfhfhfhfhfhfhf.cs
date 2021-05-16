using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class hfehfhfhfhfhfhfhf : MonoBehaviour 
{
	public float myHealth;
	public GameManager gameManager;
	public float bulletTimer ;
	public bool outOfBulletsBool;
	public GameObject bulletTransparent;
	// Use this for initialization
	void Start () 
	{
		//DontDestroyOnLoad (gameObject);

        myHealth = 1;
		
	}
	
	// Update is called once per frame
	void Update ()
	{
		if (gameManager.hasGameStarted == true) 
		{
            if (myHealth >= 0f)
            {
                if (Input.GetKeyDown(KeyCode.Mouse0))
                {
                    GetComponent<Image>().fillAmount -= +0.08333333333f;
                    Debug.Log(myHealth = GetComponent<Image>().fillAmount);
                }
            }
			
		}
		if (GetComponent<Image> ().fillAmount <= 0.08333333333f) 
			{
			outOfBulletsBool = true;
			}

		if (outOfBulletsBool == true)
			{
				bulletTimer += Time.deltaTime;
			}
		if (bulletTimer <= 0.5f) 
		{
			bulletTransparent.GetComponent<Image> ().enabled = true;
				
		} else if (bulletTimer <= 1) 
		{
			bulletTransparent.GetComponent<Image> ().enabled = false;
		} 
		else 
		{
			bulletTimer = 0;
		}

        
	}
	//public void TakeDamage()
	//{
	///	GetComponent<Image> ().fillAmount +=  -0.16666666666f;
		//Debug.Log ("jfnjfnj");
	//}
}
