using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundMusic : MonoBehaviour {

	public AudioClip winMusic;
	public AudioClip startMusic;
	public AudioClip gameMusic;

	private bool playing = false;
	private AudioSource music;


	// Use this for initialization
	void Start () {
		if (playing != false) {
			Destroy (gameObject);
		} else {
			GameObject.DontDestroyOnLoad (gameObject);
			music = GetComponent<AudioSource> ();
			music.clip = startMusic;
			music.loop = true;
			music.Play ();
		}

	}

	void OnLevelWasLoaded(int level){
		music.Stop ();
		if (level >= 0 && level <= 4) {
			music.clip = gameMusic;
		} else if (level == 5) {
			music.clip = winMusic;
		}

		music.loop = true;
		music.Play ();

	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
