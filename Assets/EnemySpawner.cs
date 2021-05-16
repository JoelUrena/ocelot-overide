using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour {

	public Vector3[] positions;
	public GameObject enemyPrefab;
	public Transform enemyGrourp;
	
	

	public GameManager manager;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		//if (manager.hasGameStarted)
			//transform.Translate (Vector3.back * 0.1f, Space.World);
		if (Camera.main.transform.position.z > transform.position.z) {
			for (int i = 0; i < positions.Length; i++) {
				Instantiate (enemyPrefab, positions [i], Quaternion.identity, enemyGrourp);
			}
			Destroy (gameObject);
		}
		
	}
}
