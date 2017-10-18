using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour {

	public Paddle paddle;

	private Vector3 paddleToBall;

	private bool isStarted = false;

	// Use this for initialization
	void Start () {

		paddleToBall =  this.transform.position - paddle.transform.position;
		
	}
	
	// Update is called once per frame
	void Update () {
		
		if (!isStarted) {
			this.transform.position = paddle.transform.position + paddleToBall;
		}
			
		if (Input.GetMouseButtonDown (0)) {

			isStarted = true;
			this.GetComponent<Rigidbody2D>().velocity = new Vector2 (2f, 10f);

		}

	}
}
