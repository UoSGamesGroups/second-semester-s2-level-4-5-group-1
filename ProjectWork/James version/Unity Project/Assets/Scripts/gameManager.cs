
using UnityEngine;
using UnityEngine.SceneManagement;

public class gameManager : MonoBehaviour {

    static public int totalPoints = 0;
    public int sceneIDBlue;
    public int sceneIDRed;

    void checkCapturePoints()
    {
        if(totalPoints == 3)
        {
            if(scoreHandler.scoreBlue > scoreHandler.scoreRed)
            {
                SceneManager.LoadScene(sceneIDBlue);
                scoreHandler.scoreBlue = 0;
                scoreHandler.scoreRed = 0;
                totalPoints = 0;
            }
            else
            {
                SceneManager.LoadScene(sceneIDRed);
                scoreHandler.scoreBlue = 0;
                scoreHandler.scoreRed = 0;
                totalPoints = 0;
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        checkCapturePoints();
    }
}
