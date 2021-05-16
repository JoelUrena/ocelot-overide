using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class wallScript : MonoBehaviour
{
    public AudioSource forklift;
    public Vector3 upMovement;
    public GameObject wall;
    public Vector3[] positions;
    public GameObject challenge1;
    public float timer;
    public GameObject timerText;

    public GameManager manager;
    // Use this for initialization
    void Start()
    {
        challenge1.SetActive(false);
        timer = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
        if (Camera.main.transform.position.z > transform.position.z)
        {
            Debug.Log("Hi I exceed you!");
            
           if (!forklift.isPlaying)
           {
               forklift.Play();
                manager.timer = 0;
            }
            wall.GetComponent<Transform>().Translate(upMovement);
            challenge1.SetActive(true);
            timer += Time.deltaTime;
           
            timerText.GetComponent<Text>().text = " : " + Mathf.RoundToInt(timer).ToString();//the text of the timer in the canvas is equal to the integer timer but is also rounded to the nearest integer
            timerText.SetActive(true);
        }
        if (timer >= 6)
        {
            challenge1.SetActive(false);

        }
        
    }
}
    