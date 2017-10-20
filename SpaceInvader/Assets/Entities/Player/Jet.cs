using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jet : MonoBehaviour {

	public float speed;
	public GameObject laser;
	public float laserSpeed;
	public float fireRate = 0.2f;


	private float minX;
	private float maxX;

	// Use this for initialization
	void Start () {
		float distance = transform.position.z - Camera.main.transform.position.z;
		Vector3 left = Camera.main.ViewportToWorldPoint(new Vector3(0,0,distance));
		Vector3 right = Camera.main.ViewportToWorldPoint(new Vector3(1,0,distance));
		minX = left.x;
		maxX = right.x;
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
		GameObject beam = Instantiate (laser, this.transform.position, Quaternion.identity) as GameObject;
		beam.GetComponent<Rigidbody2D>().velocity = new Vector3 (0, laserSpeed, 0);
	}
}
