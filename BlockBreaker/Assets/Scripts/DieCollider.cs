using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DieCollider : MonoBehaviour {
	public LevelManager levelManaber;

	void OnTriggerEnter2D(Collider2D collision) {
		print ("Trigger");
		levelManaber.LoadLevel ("Win");
	}

}
