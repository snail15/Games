using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour {

	public float health = 150f;
	public GameObject laser;

	void OnTriggerEnter2D(Collider2D col){
		print ("Trigger");
		Laser laser = col.gameObject.GetComponent<Laser>();
		if (laser != null) {
			health -= laser.GetDamage();
			laser.Destroy ();
		}
		if (health <= 0) {
			Destroy (gameObject);
		}
	}
}
