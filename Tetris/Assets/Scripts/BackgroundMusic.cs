using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundMusic : MonoBehaviour {
    
    public AudioClip gameMusic;

    public static BackgroundMusic instance = null;
    private AudioSource music;


    // Use this for initialization
    void Start()
    {
        if (instance != null)
        {
            Debug.Log("MP Destroyed");
            Destroy(gameObject);
        }
        else
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
            music = GetComponent<AudioSource>();
            music.clip = gameMusic;
            music.loop = true;
            music.Play();
        }

    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
