using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class cameraMovement : MonoBehaviour {
    public Vector3 leftMovement;
    public Vector3 rightMovement;

 
	// Use this for initialization
	void Start () {
		DontDestroyOnLoad (gameObject);

	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey(KeyCode.A))
        {
            GetComponent<Transform>().Translate(leftMovement);
        }
        if (Input.GetKey(KeyCode.D))
        {
            GetComponent<Transform>().Translate(rightMovement);
        }
	}
	void OnTriggerEnter (Collider collider)
	{
		if (collider.gameObject.tag == "Transition") //if the what ever collides has the tag "transition"
		{
			int scoreTemp = GameObject.Find ("GameManager").GetComponent<GameManager> ().scoreTemp;//the integer of score temp equals the score temp (same as saying when public game manager)
			int scoreUI = GameObject.Find ("GameManager").GetComponent<GameManager> ().scoreUI;
			int bullets = GameObject.Find ("GameManager").GetComponent<GameManager> ().bullets;

			PlayerPrefs.SetInt ("ScoreTemp", scoreTemp);
			PlayerPrefs.SetInt ("ScoreUI", scoreUI);
			PlayerPrefs.SetInt ("Bullets", bullets);

			SceneManager.LoadScene("Part 2"); 
		}
	}
}
