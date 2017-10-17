using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour {

	public Text start;

	public void LoadLevel(string level){

		Debug.Log ("Clicked!" + level );
		SceneManager.LoadScene (level);
	}
}
