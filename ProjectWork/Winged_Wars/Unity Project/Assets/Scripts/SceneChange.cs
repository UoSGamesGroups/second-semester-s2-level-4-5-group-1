using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChange : MonoBehaviour {

    public int sceneIDToLoad;
	
	public void sceneSelect () {
        SceneManager.LoadScene(sceneIDToLoad);
	}

}
