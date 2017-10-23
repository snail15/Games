using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shredder : MonoBehaviour {

	private Jet player;

	void Start(){
		player = GameObject.FindObjectOfType<Jet> ();
	}

	void OnTriggerEnter2D(Collider2D col){
		
		Destroy (col.gameObject);
		player.GainOneFire ();
	}

}
