using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Part2Script : MonoBehaviour {
    public bool hasGameStarted;
    public GameObject player;
	public GameObject pauseText;
	public GameObject doomGuy;
	public MoveSphere containerMovement; //the script "MoveSphere" is now considered as "container Movement"
	public float timer;
	public int scoreTemp;
	public int bullets;
	public int scoreUI; 
	public GameObject timerText;
	public GameObject freeFallLogo;
	public GameObject ScoreImage;
	public GameObject bulletTally;
    public TutorialScript tutorial;
	public AudioSource BGM;
    public GameObject bulletUi;
	public Vector2 upMovement;
	public AudioSource forklift;

	// Use this for initialization
	void Start () 
	{
		
		freeFallLogo.SetActive (false);
		hasGameStarted = true;
		containerMovement = FindObjectOfType <MoveSphere> ();//the object of container movement is equal to the script movesphere



	}

	// Update is called once per frame
	void Update () {
		if (hasGameStarted == false)
		{
			bulletUi.SetActive (false);
			freeFallLogo.SetActive (true);
			containerMovement.GetComponent<MoveSphere>().enabled = false; 
			player.GetComponent<SpriteRenderer>().enabled = false;
			pauseText.SetActive (true);
			timerText.SetActive (false);
			ScoreImage.SetActive (false);
			//containerMovement.SetActive (false);//container movement is set to false
		}
		if (hasGameStarted == true)
		{
			timer += Time.deltaTime;
			timerText.GetComponent<Text>().text = "Time: " + Mathf.RoundToInt(timer).ToString();//the text of the timer in the canvas is equal to the integer timer but is also rounded to the nearest integer
			timerText.SetActive (true);

			freeFallLogo.GetComponent<Transform> ().Translate (upMovement);
			bulletUi.SetActive (true);
			//freeFallLogo.SetActive (false);
			containerMovement.GetComponent<MoveSphere>().enabled = true;
			player.GetComponent<SpriteRenderer>().enabled = true;
			pauseText.SetActive (false);
			ScoreImage.SetActive (true);
			ScoreImage.GetComponent<Text> ().text = "Score: " + scoreUI.ToString ();

			//containerMovement.SetActive (true);
		}
		if (Input.GetKeyDown(KeyCode.Space) && hasGameStarted == false)
		{
			if (!BGM.isPlaying) {//if bgm isn't playing 
				BGM.Play ();//then play it
			}
			if (!forklift.isPlaying) 
			{
				forklift.Play();
			}
			tutorial.tutorialMode = true;
			hasGameStarted = true;
		}
		if (Input.GetKey(KeyCode.Return))
		{
			hasGameStarted = false;
		}
		if (scoreTemp == 2)//if the score temp equals 2, 
		{
			bullets += 1;//then the bullet adds by one 
			bulletUi.GetComponent<Image>().fillAmount += 0.08333333333f;
			scoreTemp = 0;//and the temp score equals zero
		}





	}
}
