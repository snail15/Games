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

	public void LoadNextLevel(){
		int index = SceneManager.GetActiveScene ().buildIndex;
		if (index < 3) {
			SceneManager.LoadScene (SceneManager.GetActiveScene ().buildIndex + 1);
		} else {
			SceneManager.LoadScene (5);
		}

	}

	public void LoadLoseScene(){
		SceneManager.LoadScene (4);
	}
}
