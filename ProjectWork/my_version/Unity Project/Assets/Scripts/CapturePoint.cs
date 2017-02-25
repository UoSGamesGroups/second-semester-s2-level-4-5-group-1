using System;
using System.Collections;
using UnityEngine;

public class CapturePoint : MonoBehaviour
{

    [SerializeField]
    private scoreHandler scoreHandler;

    private const float TICKS_LIFESPAN = 5.0f;
    private const int POINTS_PER_TICK = 10;
    private const int POINTS_BONUS = 100;
    private const float SCORE_RATE = 1.0f;

    private readonly Color32 clrBlue = new Color32(0, 0, 255, 255);
    private readonly Color32 clrRed = new Color32(255, 0, 0, 255);
    private readonly Color32 clrDefault = new Color32(255, 255, 255, 255);

    private enum Team { NONE, BLUE, RED };
    Team capturerTeam = Team.NONE;

    private float lastScore = 0;
    private int count = 0;

    void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.CompareTag("Blue_Team"))
        {
            capturerTeam = Team.BLUE;
            GetComponent<SpriteRenderer>().color = clrBlue;
        }
        else if(collision.gameObject.CompareTag("Red_Team"))
        {
            capturerTeam = Team.RED;
            GetComponent<SpriteRenderer>().color = clrRed;
        }
        lastScore = Time.realtimeSinceStartup;
    }

/*  	private void OnTriggerExit2D(Collider2D collision)
    {
        GetComponent<SpriteRenderer>().color = clrDefault;
        capturerTeam = Team.NONE;
    }
*/	 
    private void OnTriggerStay2D(Collider2D collision)
    {
        if(capturerTeam == Team.NONE)
        {
            return;
        }

        if(Time.realtimeSinceStartup - lastScore > SCORE_RATE)
        {
            switch(capturerTeam)
            {
                case Team.RED:
                    scoreHandler.setRedScore(scoreHandler.getRedScore() + POINTS_PER_TICK);
                    break;
                case Team.BLUE:
                    scoreHandler.setBlueScore(scoreHandler.getBlueScore() + POINTS_PER_TICK);
                    break;
            }
            lastScore = Time.realtimeSinceStartup;
            count++;

            if(count >= TICKS_LIFESPAN)
            {
                Destroy(gameObject);
            }
        }
    }

}
