using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class ScoreKeeper : MonoBehaviour {

    public Text scoreText;

	// Use this for initialization
	void Start () {

        scoreText.text = Shape.score.ToString();
        Shape.ResetScore();
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
