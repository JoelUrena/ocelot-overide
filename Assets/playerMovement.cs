using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class playerMovement : MonoBehaviour {
    public Vector3 leftMovement;
    public Vector3 rightMovment;
    public Vector3 upMovement;
    public Vector3 downMovement;
	public GameManager gameManager;
    public hfehfhfhfhfhfhfhf bulletSlider;//NEW RULE: PUBLIC (SCRIPT YOU WANT TO ADD) NAMEOFWHAT THE SCRIPT YOU WANT IT TO BE CALLED
    public AudioSource ShootSound;
	public AudioClip shootSoundClip;
    public AudioSource NoAmmo;
    public AudioSource LowAmmoSignal;
	public Animator anim;


	// Use this for initialization
	void Start () {
		//DontDestroyOnLoad (gameObject);
		//Animator.Play (IdleShoot);
		//anim.SetInteger ("anim", 0);
	
	}
	
	// Update is called once per frame
	void Update ()
	{
		if (Input.GetAxis ("Mouse X") < 0 && GetComponent<Transform>().position.x > -0.7f) {//if the x axis of the mouse is less than zero (moved to the left) (also if the position is greter than -0.7) <---need to do that
			GetComponent<Transform> ().Translate (leftMovement);//then left arrow is initiated
		}
		if (Input.GetAxis ("Mouse X") > 0 && GetComponent<Transform>().position.x < 0.7f) {//if the x axis of the mouse is less than zero (moved to the left) (also if the position is greter than -0.7) <---need to do that
			GetComponent<Transform> ().Translate (rightMovment);//then left arrow is initiated
		}

		//Vector3 posCenter = Input.mousePosition - new Vector3 (Screen.width / 2f, Screen.height / 2f, 0f);
		//if (posCenter.x < 0 && transform.position.x > -0.7f) {
		//	GetComponent<Transform> ().Translate (leftMovement * 3f);//then left arrow is initiated
		//}
		//if (posCenter.x > 0 && transform.position.x < 0.7f) {
		//	GetComponent<Transform> ().Translate (rightMovment * 3f);//then right movement is initiated
		//}

//		Debug.Log ("posCenter = " + posCenter);
		if (Input.GetAxis ("Mouse Y") < 0 && GetComponent<Transform>().position.y > -1.35f ) {//if the y axis of the mouse is less than 0 (mouse moved down)
			GetComponent<Transform> ().Translate (downMovement);//then downmovement is initiated
		}
		if (Input.GetAxis ("Mouse Y") > 0 && GetComponent<Transform>().position.y < -0.4f) {//if the y axis of the mouse is greater than 0 (mouse moved up)
			GetComponent<Transform> ().Translate (upMovement);//the upMovement is initiated
		}

        if (bulletSlider.myHealth <= 0f && Input.GetKeyDown(KeyCode.Mouse0))
        {
            //anim.SetInteger ("anim", 1);//animation set the integer is 1 then it animates. we set the integer 0 to idle and 1 to animate in the animation window 
            
            if (!NoAmmo.isPlaying)
            {
                NoAmmo.Play();
            }
			//Animator.Play (AnimShoot);
        }
        if (bulletSlider.myHealth <= 0.08333333333f)
        {
            if (!LowAmmoSignal.isPlaying)
            {
                LowAmmoSignal.Play(); 
            }
        }
		//if(anim.SetBool)
		{

		}

        if (gameManager.hasGameStarted == true)
        {
            
            if (bulletSlider.myHealth != 0f && Input.GetKeyDown(KeyCode.Mouse0))//if the bullets do not equal zero and left mouse is pressed,
            {
				AudioSource.PlayClipAtPoint (shootSoundClip, transform.position);
               
				anim.SetTrigger("shoot");
				Debug.Log ("<color=red>Yes it shoots!</color>");

               // if (!ShootSound.isPlaying)
                //{
                //    ShootSound.Play(); 
               // }
                    gameManager.bullets += -1;//you loose a bullet
                                              //gameManager.bulletTally.GetComponent<ImagePo
                                              //Vector3 fwd = transform.TransformDirection (Vector3.forward);//vector 3 with the tempoary variable, "fwd", is equal to the direction of vector's 3 foward (short cut for 0,0,1)
                    Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
                    RaycastHit hit;//the container for the information on the object we hit

				if (Physics.Raycast(ray, out hit, Mathf.Infinity, 1<<LayerMask.NameToLayer("Enemy")))
                    {//convert the point of the parantheses from screen space to world space 
					//Debug.DrawRay;
                        Debug.Log(hit.transform.name);//gives us the name of the thing we hit with the ray cast

                    if (hit.transform.name.Contains("doom"))
                    { //if the name of the thing we hit with the ray cast contains the word doom
                        Destroy(hit.transform.gameObject); //destroy the gameobject of the thing we hit, it something has been hit
                        gameManager.scoreTemp += 1;//the temporary score adds by 1
                        gameManager.scoreUI += 100;//the ui score adds by 100
                        gameManager.timesCounter += 1;
                        gameManager.tempBullet += 1;
                    }
                    
                        
                    
                    }
                else
                {
                    
                    gameManager.timesCounter = 0;
                    

                }
            }
            
            

		}
	}


}
