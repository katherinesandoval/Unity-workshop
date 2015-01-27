using UnityEngine;
using System.Collections;

public class EnemyFactory : MonoBehaviour {

	public float timer;
	public float minX, maxX;
	public GameObject enemyObject;
	private float timeToSpawn;


	// Use this for initialization, only runs once
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		float newX = Random.Range (minX, maxX);
		transform.position = new Vector3 (newX, 20f, 0);

		if (timeToSpawn < 0) {
			// Duplicaes objects
			GameObject g = (GameObject)Instantiate(enemyObject, transform.position, Quaternion.identity);
			Destroy(g, 5f);
			timeToSpawn = timer;
		}
		timeToSpawn = timeToSpawn - Time.deltaTime;
	}
}
