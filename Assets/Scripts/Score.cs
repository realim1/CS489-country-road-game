
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour {

    int score = 0;
    public Text scoreText;
    public Text gameoverText;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (FindObjectOfType<Game_Controller>().game_is_over == false)
        {
            gameoverText.enabled = false;
            score++;
            scoreText.text = "Distance: " + score.ToString();
        }
        else
        {
            gameoverText.enabled = true;
        }
	}
}
