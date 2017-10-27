using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShapeSpawner : MonoBehaviour {

    public GameObject[] shapes;
    public static int idx;
    public GameObject[] next;

    GameObject nextShape = null;

    private int nextIdx;

    public void Spawn(){

        idx = nextIdx;
        Instantiate(shapes[idx], transform.position, Quaternion.identity);
        nextIdx = Random.Range(0, 7);

        if(nextShape != null) {
            Destroy(nextShape);
        }

        Vector3 nextShapePosition = new Vector3(-5.5f, 15.5f, 0);
        nextShape = Instantiate(next[nextIdx], nextShapePosition, Quaternion.identity);

    }

	// Use this for initialization
	void Start () {

        nextIdx = Random.Range(0, 7);
        Spawn();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
