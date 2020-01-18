using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Repeating_Background : MonoBehaviour {


    private BoxCollider2D leftSideCollider;
    private float leftSideLength;
    

	// Use this for initialization
	void Start () {
        leftSideCollider = GetComponentInChildren<BoxCollider2D>();
        leftSideLength = leftSideCollider.size.y;
        
	}
	
	// Update is called once per frame
	void Update () {

        if ( transform.position.y < -leftSideLength)
        {
            RepositionBackground();
        }

	}

    private void RepositionBackground()
    {
        Vector2 sideOffset = new Vector2(0, leftSideLength * 2f);
        transform.position = (Vector2)transform.position + sideOffset;
        
    }
}
