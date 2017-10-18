using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Brick : MonoBehaviour {

	public int maxHit;
	private int numHit;

	// Use this for initialization
	void Start () {
		numHit = 0;
	}

	void OnCollisionEnter2D (Collision2D collision){
		numHit += 1;
		print (maxHit + " brick hit!");
	}
}
