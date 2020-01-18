using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Parallax_Script : MonoBehaviour {

    private Rigidbody2D rb;

    // Use this for initialization
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.velocity = new Vector2(0, Game_Controller.instance.scrollSpeed);
    }

	// Update is called once per frame
	void Update () {
		
	}
}
