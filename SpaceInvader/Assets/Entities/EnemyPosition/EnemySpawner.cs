﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour {

	public GameObject enemyPrefab;
	public LevelManager levelManager;

	public float width = 10f;
	public float height = 5f;
	public float speed = 2f;
	public float spawnDelay = 0.5f;

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
		SpawnEnemyUntilFull ();
		levelManager = GameObject.FindObjectOfType<LevelManager> ();

	}

	void SpawnEnemy(){
		foreach (Transform child in this.transform) {

			float positionX = child.transform.position.x;
			float positionY = child.transform.position.y;
			float positionZ = child.transform.position.z;

			GameObject enemy = Instantiate (enemyPrefab, new Vector3 (positionX,positionY,positionZ), Quaternion.identity) as GameObject;
			enemy.transform.parent = child;

		}
	}

	void SpawnEnemyUntilFull(){
		Transform freePosition = NextFreePosition ();
		if (freePosition != null) {
			GameObject enemy = Instantiate (enemyPrefab, freePosition.position, Quaternion.identity) as GameObject;
			enemy.transform.parent = freePosition;
		}

		if (NextFreePosition ()) {
			Invoke ("SpawnEnemyUntilFull", spawnDelay);
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

		if (AllMembersDead ()) {
//			SpawnEnemyUntilFull ();
			levelManager.LoadNextLevel ();

		}
	}

	Transform NextFreePosition(){
		foreach (Transform childPosition in this.transform) {
			if (childPosition.childCount == 0) {
				return childPosition;
			}
		}
		return null;
	}

	bool AllMembersDead(){
		foreach (Transform childPosition in this.transform) {
			if (childPosition.childCount > 0) {
				return false;
			}
		}
		return true;
	}
}
