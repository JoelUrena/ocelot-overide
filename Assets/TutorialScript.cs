using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TutorialScript : MonoBehaviour {
    public GameManager gamemanager;
    public bool tutorialMode;
    public bool tutorialMode2;
    public bool tutorialMode3;
    public bool tutorialMode4;
    public bool tutorialMode5;
    public float timer;
    public AudioSource tut1;
    public AudioSource tut2;
    public AudioSource tut3;
    public AudioSource tut4;
    public AudioSource tut5;


    // Use this for initialization
    void Start () {
        tutorialMode = false;
        tutorialMode2 = false;
        tutorialMode3 = false;
        tutorialMode4 = false;
        tutorialMode5 = false;

    }
	
	// Update is called once per frame
	void Update () {

        if (tutorialMode == true)//if tut mode is true
        {

            if (!tut1.isPlaying)//and tut mode song isnt playing
            {
                tut1.Play();//play tut mode song
                tutorialMode = false;//turn tut mode off
                tutorialMode2 = true;//turn tut mode 2 on

            }
        }
            if (tutorialMode2 == true && gamemanager.timer >= 7)//if tut mode 2 is true and game manager's timer is greater than or equal to 7, using game manager timer because if i insert timer in tutmode = true, once it becomes false, timer would as well. if i leave it in update, it will start regardless if game has started or not.
            {
                if (!tut2.isPlaying)//if tut mode  2 is NOT playing
                { 
                    tut2.Play();//play tut 2
                tutorialMode2 = false;
                tutorialMode3 = true;
                }
            }

            if (tutorialMode3 == true && gamemanager.timer >= 21)
            {
                if (!tut3.isPlaying)
                { 
                    tut3.Play();
                tutorialMode3 = false;
                tutorialMode4 = true;
                }

            }

            if (tutorialMode4 == true && gamemanager.timer >= 30)
            {
                if (!tut4.isPlaying)
                { 
                    tut4.Play();
                tutorialMode4 = false;
                tutorialMode5 = true;
                }
            }

            if (tutorialMode5 == true && gamemanager.timer >= 35)
            {
                if (!tut5.isPlaying)
                { 
                    tut5.Play();
                tutorialMode5 = false;
                }
            }

        
	}
}
