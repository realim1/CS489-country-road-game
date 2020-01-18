using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Car_Movement : MonoBehaviour {


    private Rigidbody2D rb;


	// Use this for initialization
	void Start () {
        rb = GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update () {
        //rb.AddForce(new Vector2(0, 9));

        if (Input.GetKey(KeyCode.RightArrow))
        {
            rb.AddForce(new Vector2(3.5f, 0));
        }

        else if (Input.GetKey(KeyCode.LeftArrow))
        {
            rb.AddForce(new Vector2(-3.5f, 0));
        }
	}
}
