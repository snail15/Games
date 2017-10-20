using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Laser : MonoBehaviour {

	private float damage = 100f;

	public float GetDamage(){
		return damage;
	}

	public void Destroy(){
		Destroy (gameObject);
	}
}
