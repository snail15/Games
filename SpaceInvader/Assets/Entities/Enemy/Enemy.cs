using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour {

	public float health = 150f;
	public GameObject laser;
	public float laserSpeed = 5f;
	public float shotsPerSecond = 0.5f;
	public GameObject particle;

	private Jet jet;

	void Start(){
		jet = GameObject.FindObjectOfType<Jet> ();
	}


	void Update(){
		float prob = Time.deltaTime * shotsPerSecond;
		if (Random.value < prob) {
			Fire ();
		}
		
	}

	void OnTriggerEnter2D(Collider2D col){
		
		Laser laser = col.gameObject.GetComponent<Laser>();
		if (laser != null) {
			health -= laser.GetDamage();
			laser.Destroy ();
		}
		if (health <= 50) {
			SpriteRenderer renderer = gameObject.GetComponent<SpriteRenderer> ();
			renderer.color = Color.red;
		}
		if (health <= 0) {
			Destroy (gameObject);
			Instantiate (particle, transform.position, Quaternion.identity);
		}
		jet.GainOneFire ();
	}

	void Fire(){
		Vector3 startPosition = transform.position + new Vector3 (0, -0.6f);
		GameObject enemyLaser = Instantiate (laser, startPosition, Quaternion.identity) as GameObject;
		enemyLaser.GetComponent<Rigidbody2D> ().velocity = new Vector2 (0, -laserSpeed);
	}
}
