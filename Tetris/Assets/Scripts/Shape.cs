using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Shape : MonoBehaviour {

    public static float speed = 1.0f;
    public static int score = 0;

    private float lastMoveDown = 0;



    // Use this for initialization
    void Start () {

        if (!isInGrid()){
            SoundManager.instance.PlayOneShot(SoundManager.instance.gameOver);

            Invoke("GameOver", 0.2f);
        }

        InvokeRepeating("IncreaseSpeed", 2.0f, 2.0f);
		
	}

    public static void ResetScore(){
        score = 0;
    }

    void GameOver(){

        Destroy(gameObject);
        SceneManager.LoadScene("Lose");
    }

    void IncreaseSpeed(){

        Shape.speed -= 0.0001f;
    }
	
	// Update is called once per frame
	void Update () {

        if(Input.GetKeyDown(KeyCode.LeftArrow)){
            transform.position += new Vector3(-1, 0, 0);
            Debug.Log(transform.position);

            if(!isInGrid()){
                transform.position += new Vector3(1, 0, 0);
            } else {
                UpdateBoard();

            }
        }
		
        if(Input.GetKeyDown(KeyCode.DownArrow) || Time.time - lastMoveDown >= Shape.speed){
            transform.position += new Vector3(0, -1, 0);
            Debug.Log(transform.position);
            if (!isInGrid()) {

                bool rowDeleted = GameScreen.CanDeleteRow();

                if(rowDeleted){
                    GameScreen.CanDeleteRow();
                    UpdateScore();
                }
                transform.position += new Vector3(0, 1, 0);
                enabled = false;
                FindObjectOfType<ShapeSpawner>().Spawn();
                SoundManager.instance.PlayOneShot(SoundManager.instance.shapeStop);

            } else
            {
                UpdateBoard();
               
            }

            lastMoveDown = Time.time;
        }

        if(Input.GetKeyDown(KeyCode.RightArrow)){
            transform.position += new Vector3(1, 0, 0);
            Debug.Log(transform.position);
            if (!isInGrid())
            {
                transform.position += new Vector3(-1, 0, 0);
            } else
            {
                UpdateBoard();

            }
        }

        if(Input.GetKeyDown(KeyCode.UpArrow)){
            int idx = ShapeSpawner.idx;
            if(idx != 0){
                transform.Rotate(0, 0, 90);
                Debug.Log(transform.position);
                if (!isInGrid())
                {
                    transform.Rotate(0, 0, -90);
                }else
                {
                    UpdateBoard();
                }
            }
                
        }
	}

    public bool isInGrid() {

        int childCount = 0;
        foreach (Transform childBlock in transform)
        {
            Vector2 vector = RoundVector(childBlock.position);
            childCount++;

            Debug.Log(childCount + " " + childBlock.position);

            if(!isInScreen(vector)){
                return false;
            }

            if(GameScreen.gameBoard[(int)vector.x, (int)vector.y] != null &&
               GameScreen.gameBoard[(int)vector.x, (int)vector.y].parent != transform){
                return false;
            }
        }
        return true;

    }
    public static bool isInScreen(Vector2 position){
        return ((int)position.x >= 0 && (int)position.x <= 9
                && (int)position.y >= 0);
    }

    public Vector2 RoundVector(Vector2 vect)
    {
        return new Vector2(Mathf.Round(vect.x), Mathf.Round(vect.y));
    }

    public void UpdateBoard(){
        for (int y = 0; y < 20; ++y){
            for (int x = 0; x < 10; ++x){
                
                if (GameScreen.gameBoard[x, y] != null &&
                    GameScreen.gameBoard[x, y].parent == transform) {

                    GameScreen.gameBoard[x, y] = null;
                }
            }
        }
       
        foreach (Transform childBlock in transform) {
            
            Vector2 vect = RoundVector(childBlock.position);

            GameScreen.gameBoard[(int)vect.x, (int)vect.y] = childBlock;

            Debug.Log("Cube At : " + vect.x + " " + vect.y);

        }
    }

    void UpdateScore(){

        var textUI = GameObject.Find("Score").GetComponent<Text>();

        score = int.Parse(textUI.text);
        score += 1;

        textUI.text = score.ToString();

    }
}
