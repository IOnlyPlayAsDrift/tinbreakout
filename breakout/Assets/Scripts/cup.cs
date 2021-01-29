using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class cup : MonoBehaviour
{
    SpriteRenderer spriteRenderer;
    PolygonCollider2D coll;

    // Start is called before the first frame update
    void Start()
    {
        this.spriteRenderer = GetComponent<SpriteRenderer>();
        coll = GetComponent<PolygonCollider2D>();
        this.spriteRenderer.enabled = false;
        this.coll.enabled = false;
    }

    public void Cup()
    {
        this.spriteRenderer.enabled = true;
        this.coll.enabled = true;
    }

    void OnMouseDown()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Scene currentScene = SceneManager.GetActiveScene();
            string sceneName = currentScene.name;
            if (sceneName == "Level 1")
            {
                SceneManager.LoadScene("Level 1");
            }

            if (sceneName == "Level 2")
            {
                SceneManager.LoadScene("Level 2");
            }

            if (sceneName == "Level 3")
            {
                SceneManager.LoadScene("Level 3");
            }

            if (sceneName == "Level 4")
            {
                SceneManager.LoadScene("Level 4");
            }
        }
    }
}
