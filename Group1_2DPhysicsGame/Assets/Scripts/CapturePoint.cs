using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CapturePoint : MonoBehaviour 
{
    public GUIText scoreText;
    public int score;

    private void Start()
    {
        score = 0;
        UpdateScore();
    }


	void UpdateScore ()
    {
        scoreText.text = "Blue: " + score;		
	}

	void OnTriggerEnter2D(Collider2D other)
	{

	}
}
