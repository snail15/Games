using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameDirector : MonoBehaviour {

	private GameObject hpGage;
	// Use this for initialization
	void Start () {
		this.hpGage = GameObject.Find ("hpGage");
	}
	
	public void DecreaseHpGage(){
		hpGage.GetComponent<Image> ().fillAmount -= 0.335f;
	}
}
