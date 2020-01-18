using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Kill_Objects : MonoBehaviour {


       void OnTriggerEnter2D(Collider2D col)
    {

        if (col.gameObject.tag == "Obstacle")
        {
            Destroy(col.gameObject);
        }

    }
}
