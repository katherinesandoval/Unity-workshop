using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	// You can change what keys to use for the user input
	void Update () {
		// Debug.Log("Hello World!!");
		if(Input.GetKey(KeyCode.RightArrow) && transform.position.x < 8){
			// to keep inside a coordinatre
			// deltaTime how long the frame took, so it wont run faster on one comp or another
			transform.position += new Vector3 (10, 0, 0) * Time.deltaTime;
		}

		if(Input.GetKey(KeyCode.LeftArrow) && transform.position.x > -8){
			// to keep inside a coordinatre
			// deltaTime how long the frame took, so it wont run faster on one comp or another
			transform.position += new Vector3 (-10, 0, 0) * Time.deltaTime;
		}

		if(Input.GetKey(KeyCode.UpArrow) && transform.position.y < 4){
			// to keep inside a coordinatre
			// deltaTime how long the frame took, so it wont run faster on one comp or another
			transform.position += new Vector3 (0, 10, 0) * Time.deltaTime;
		}

		// smaller number because screen is wider than taller
		if(Input.GetKey(KeyCode.DownArrow) && transform.position.y > -4){
			// to keep inside a coordinatre
			// deltaTime how long the frame took, so it wont run faster on one comp or another
			transform.position += new Vector3 (0, -10, 0) * Time.deltaTime;
		}
	}

	void OnTriggerEnter(Collider other){
		Debug.Log ("collision!!!!!!!!");
		Application.LoadLevel("fin");
	}
}