using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera_Movement : MonoBehaviour {


    public Transform playerCoordinates;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        transform.position = new Vector3(0, playerCoordinates.position.y + 4, -10);
    }
}
