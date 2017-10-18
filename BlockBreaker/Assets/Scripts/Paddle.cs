using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

		Vector3 paddlePosition = new Vector3 (this.transform.position.x, this.transform.position.y, 0f);

		float mousePosition = Input.mousePosition.x / Screen.width * 16;

		paddlePosition.x = Mathf.Clamp(mousePosition, 0.79f, 15.21f);

		this.transform.position = paddlePosition;
		
	}
}
