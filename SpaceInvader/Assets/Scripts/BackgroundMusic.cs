using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundMusic : MonoBehaviour {

	private bool playing = false;

	// Use this for initialization
	void Start () {
		if (playing != false) {
			Destroy (gameObject);
		} else {
			GameObject.DontDestroyOnLoad (gameObject);
		}

	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
