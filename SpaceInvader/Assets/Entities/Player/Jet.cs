using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jet : MonoBehaviour {

	public float speed;
	public GameObject laser;
	public AudioClip laserSound;

	public float laserSpeed;
	public float fireRate = 0.2f;
	public float health = 250f;
	public int maxFire;


	private float minX;
	private float maxX;
	private int remainingFire;
	private GameObject director;
	private LevelManager levelManager;


	// Use this for initialization
	void Start () {
		director = GameObject.Find ("Gamedirector");
		levelManager = GameObject.FindObjectOfType<LevelManager> ();
		float distance = transform.position.z - Camera.main.transform.position.z;
		Vector3 left = Camera.main.ViewportToWorldPoint(new Vector3(0,0,distance));
		Vector3 right = Camera.main.ViewportToWorldPoint(new Vector3(1,0,distance));
		minX = left.x;
		maxX = right.x;
		remainingFire = maxFire;
	}

	// Update is called once per frame
	void Update () {

		if (Input.GetKeyDown (KeyCode.Space)) {
			InvokeRepeating ("Fire", 0.00001f, fireRate);
		}
		if (Input.GetKeyUp (KeyCode.Space)) {
			CancelInvoke ("Fire");
		}
		if (Input.GetKey (KeyCode.LeftArrow)) {
//			this.transform.position += new Vector3 (-speed * Time.deltaTime, 0, 0);
			this.transform.position += Vector3.left * speed * Time.deltaTime;
		} else if (Input.GetKey (KeyCode.RightArrow)) {
//			this.transform.position += new Vector3 (speed * Time.deltaTime, 0, 0);
			this.transform.position += Vector3.right * speed * Time.deltaTime;
		}

		float newX = Mathf.Clamp (transform.position.x, minX, maxX);
		transform.position = new Vector3 (newX, transform.position.y, transform.position.z);
	}

	void Fire(){
		if (remainingFire > 0 && remainingFire <= maxFire) {
			
			Vector3 firePosition = transform.position + new Vector3 (0, 0.6f);
			GameObject beam = Instantiate (laser, firePosition, Quaternion.identity) as GameObject;
			beam.GetComponent<Rigidbody2D>().velocity = new Vector3 (0, laserSpeed, 0);
			LaserSound ();
			DecreaseRemainingFire ();


		}
	}

	void LaserSound(){
		AudioSource.PlayClipAtPoint (laserSound, transform.position);
	}

//	void ExplosionSound(){
//		AudioSource.PlayClipAtPoint (explosionSound, transform.position);
//	}

	void DecreaseRemainingFire(){
		this.remainingFire -= 1;
	}


	void OnTriggerEnter2D(Collider2D col){
		print ("Jet Hit");
		director.GetComponent<GameDirector> ().DecreaseHpGage ();
		Laser laser = col.gameObject.GetComponent<Laser>();
		if (laser != null) {
			health -= laser.GetDamage();
			laser.Destroy ();
		}
		if (health <= 0) {
			Destroy (gameObject);
			levelManager.LoadLoseScene ();
		}
	}

	public void GainOneFire(){
		this.remainingFire += 1;
	}

}
