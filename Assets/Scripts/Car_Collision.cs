using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Car_Collision : MonoBehaviour {

    void OnTriggerEnter2D(Collider2D col)
    {
        if(col.gameObject.tag == "Obstacle")
        {
            FindObjectOfType<Game_Controller>().End_Game();
            Destroy(gameObject);
            Destroy(col.gameObject);
        }
    }


}
