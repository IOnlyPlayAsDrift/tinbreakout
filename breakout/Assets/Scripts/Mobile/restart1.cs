using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using UnityEngine;
using UnityEngine.SceneManagement;

public class restart1 : MonoBehaviour
{

    PolygonCollider2D coll;

    // Start is called before the first frame update
    public void Start()
    {
        coll = GetComponent<PolygonCollider2D>();
    }

    // Update is called once per frame
    public void OnMouseDown()
    {
        //if (Input.GetMouseButtonDown(0))
        if (Input.touchCount == 1)
        {
            if (Input.GetTouch(0).phase == TouchPhase.Began)
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
}
