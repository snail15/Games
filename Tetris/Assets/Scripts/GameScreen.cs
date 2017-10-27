using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameScreen : MonoBehaviour {

    public static Transform[,] gameBoard = new Transform[10, 20];

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public static bool CanDeleteRow(){
        
        for (int row = 0; row < 20; ++row){
            
            if(IsRowFull(row)){
                
                DeleteRow(row);

                SoundManager.instance.PlayOneShot(SoundManager.instance.rowDelete);

                return true;
            }
        }
        return false;
    }

    public static bool IsRowFull(int row){
        
        for (int col = 0; col < 10; ++col){

            if(gameBoard[col, row] == null){

                return false;
            }
        }

        return true;
    }

    public static void DeleteRow(int row){

        for (int col = 0; col < 10; ++col){

            Destroy(gameBoard[col, row].gameObject);
            gameBoard[col, row] = null;

        }

        // because we want to pull down the shapes in the rows above
        row++;

        for (int i = row; i < 20; ++i){

            for (int col = 0; col < 10; ++col){

                if(gameBoard[col, i] != null) {

                    gameBoard[col, i - 1] = gameBoard[col, i];
                    gameBoard[col, i] = null;
                    gameBoard[col, i - 1].position += new Vector3(0, -1, 0);
                }
            }
        }
        
    }
}
