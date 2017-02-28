using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneTransitioner : MonoBehaviour
{

    [SerializeField] private float fadeSpeed;
    [SerializeField] private float fadeSmoothness;

    [SerializeField] private Direction fadeDirection;

    [SerializeField] private bool active;
    [SerializeField] private bool changeScene;

    [SerializeField] private string destinationScene;

    private bool fading;

    enum Direction { IN, OUT };

    private void Start()
    {
        if(!active || GetComponent<SpriteRenderer>() == null)
        {
            return;
        }

        StartCoroutine(fadeSprite(GetComponent<SpriteRenderer>(), fadeSpeed, fadeSmoothness, fadeDirection));
    }

    private IEnumerator fadeSprite(SpriteRenderer spriteRenderer, float speed, float smoothness, Direction direction)
    {
        fading = true;
        Color32 clrDefault = spriteRenderer.color;
        if (direction == Direction.OUT)
        {
            for (var i = 0.0f; i <= 255.0f; i += smoothness)
            {
                spriteRenderer.color = new Color32(clrDefault.r, clrDefault.g, clrDefault.b, (byte)i);
                yield return new WaitForSeconds(speed);
            }
        }
        else if(direction == Direction.IN)
        {
            for (var i = 255.0f; i >= 0.0f; i -= smoothness)
            {
                spriteRenderer.color = new Color32(clrDefault.r, clrDefault.g, clrDefault.b, (byte)i);
                yield return new WaitForSeconds(speed);
            }
        }
        if (changeScene)
        {
            SceneManager.LoadScene(destinationScene, LoadSceneMode.Single);
        }
        fading = false;
    }

    public void transitionToScene(string sceneName)
    {
        destinationScene = sceneName;
        changeScene = true;
        StartCoroutine(fadeSprite(GetComponent<SpriteRenderer>(), fadeSpeed, fadeSmoothness, Direction.OUT));
    }

}
