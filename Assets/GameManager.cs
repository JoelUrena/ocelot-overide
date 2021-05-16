using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {
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
    public AudioSource reload;
    public bool isGameOverTrue;
    public GameObject gameOverScreen;
    public AudioSource gameOverSound;
    public int timesCounter;
    public GameObject multiPlyer;
    public int tempBullet;

	// Use this for initialization
	void Start () 
	{
		if (SceneManager.GetActiveScene ().name == "free falling") {
			bullets = 12;//the amount of bullets you have
			scoreTemp = 0;//the temporary score starts out at 0
			scoreUI = 0;//the score that will show in the ui will start out as 0
		} else {
			bullets = PlayerPrefs.GetInt ("Bullets");//bullets eual the integer that was gotten in bulluets (stored from camera movement) using playerprefs
			scoreUI = PlayerPrefs.GetInt ("ScoreUI");//scoreUI eual the integer that was gotten in ScoreUI (stored from camera movement) using playerprefs
			scoreTemp = PlayerPrefs.GetInt ("ScoreTemp");//scoreTemp eual the integer that was gotten in ScoreTemp (stored from camera movement) using playerprefs 
		}
		freeFallLogo.SetActive (true);
        hasGameStarted = false;
		containerMovement = FindObjectOfType <MoveSphere> ();//the object of container movement is equal to the script movesphere
		DontDestroyOnLoad (gameObject);
        //DontDestroyOnLoad (hfehfhfhfhfhfhfhf);
        isGameOverTrue = false;
        gameOverScreen.SetActive(false);
        multiPlyer.SetActive(false);

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

        if (Input.GetKeyDown(KeyCode.R))
        {
            bullets += 4;
            bulletUi.GetComponent<Image>().fillAmount += 0.3333333332f;
            if (!reload.isPlaying)
            {
                reload.Play();
            }
        }
        if (scoreUI <= 10000 && timer >= 60)
        {
            isGameOverTrue = true;
        }
        if (timer >= 54 && timer <=60)
        {
            if (!gameOverSound.isPlaying)
            {
                gameOverSound.Play();
            }
        }
        if (isGameOverTrue == true)
        {
            gameOverScreen.SetActive(true);
            
        }
        if (timesCounter >= 2)
        {
            multiPlyer.SetActive(true);
            multiPlyer.GetComponent<Text>().text = "X " + (timesCounter).ToString();

        }
        if (timesCounter <= 1)
        {

            multiPlyer.SetActive(false);
        }
        if (tempBullet == 10)
        {
            bullets += 10;
            bulletUi.GetComponent<Image>().fillAmount += 0.83333333333f;
            if (!reload.isPlaying)
            {
                reload.Play();
            }
            tempBullet = 0;
        }



    }
}
