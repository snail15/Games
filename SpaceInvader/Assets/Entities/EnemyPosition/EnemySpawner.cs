using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour {

	public GameObject enemyPrefab;

	public float width = 10f;
	public float height = 5f;
	public float speed = 2f;

	private bool movingRight = false;
	private float minX;
	private float maxX;

	// Use this for initialization
	void Start () {
		float distanceToCamera = this.transform.position.z - Camera.main.transform.position.z;
		Vector3 leftEdge = Camera.main.ViewportToWorldPoint (new Vector3 (0, 0, distanceToCamera));
		Vector3 rightEdge = Camera.main.ViewportToWorldPoint (new Vector3 (1, 0, distanceToCamera));
		minX = leftEdge.x;
		maxX = rightEdge.x;
		foreach (Transform child in this.transform) {
			
			float positionX = child.transform.position.x;
			float positionY = child.transform.position.y;
			float positionZ = child.transform.position.z;

			GameObject enemy = Instantiate (enemyPrefab, new Vector3 (positionX,positionY,positionZ), Quaternion.identity) as GameObject;
			enemy.transform.parent = child;

		}
	}

	public void OnDrawGizmos(){
		Gizmos.DrawWireCube(this.transform.position, new Vector3(width, height));
	}
	
	// Update is called once per frame
	void Update () {
		if (movingRight) {
			this.transform.position += Vector3.right * speed * Time.deltaTime;
		} else {
			this.transform.position += Vector3.left * speed * Time.deltaTime;
		}

		float rightMax = this.transform.position.x + (0.4f * width);
		float leftMax = this.transform.position.x - (0.4f * width);

		if (leftMax <= minX) {
			movingRight = true;
		}else if(rightMax >= maxX){
			movingRight = false;
		}
	}
}
