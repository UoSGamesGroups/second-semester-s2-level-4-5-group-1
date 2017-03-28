using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class scoreHandler : MonoBehaviour
{

    [SerializeField]
    private Text txtRed;

    [SerializeField]
    private Text txtBlue;

    private const string strBluePrefix = "BLUE: ";
    private const string strRedPrefix = "RED: ";

    static public int scoreRed = 0;
    static public int scoreBlue = 0;

	private void updateUI()
    {
        txtRed.text = strRedPrefix + scoreRed;
        txtBlue.text = strBluePrefix + scoreBlue;
    }

    public void setRedScore(int score)
    {
        scoreRed = score;
        updateUI();
    }

    public int getRedScore()
    {
        return scoreRed;
    }

    public void setBlueScore(int score)
    {
        scoreBlue = score;
        updateUI();
    }

    public int getBlueScore()
    {
        return scoreBlue;
    }

}
