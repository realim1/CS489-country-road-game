using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Game_Controller : MonoBehaviour
{


    public static Game_Controller instance;

    public float scrollSpeed = -2.5f;

    public bool game_is_over = false;

    void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else if (instance != null)
        {
            Destroy(gameObject);
        }
    }

    public void End_Game()
    {
        if(game_is_over == false)
        {
            game_is_over = true;
            Debug.Log("Game Over");
        }
        
    }
    
    void Update()
    {
        if(game_is_over == true && Input.GetKey(KeyCode.Q))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }


}
