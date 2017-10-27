using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour {

    public static SoundManager instance = null;



    public AudioClip gameOver;
    public AudioClip rowDelete;
    public AudioClip shapeStop;

    private AudioSource music;

	// Use this for initialization
	void Start () {

        if(instance == null){

            instance = this;
        } else if(instance != this){
            Destroy(gameObject);
        }

        AudioSource thisSource = GetComponent<AudioSource>();

        music = thisSource;
	}
	
    public void PlayOneShot(AudioClip clip){

        music.PlayOneShot(clip);
    }
}
