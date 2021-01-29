using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class swapres1 : MonoBehaviour
{

    PolygonCollider2D coll;
    Scene m_Scene;
    string sceneName;


    // Start is called before the first frame update
    public void Start()
    {
        coll = GetComponent<PolygonCollider2D>();
        m_Scene = SceneManager.GetActiveScene();
        sceneName = m_Scene.name;
    }

    // Update is called once per frame
    private void OnMouseDown()
    {
        //if (Input.GetMouseButtonDown(0))
        if (Input.touchCount == 1)
        {
            if (Input.GetTouch(0).phase == TouchPhase.Began)
            {
                if (sceneName == "Level 3")
                {
                    SceneManager.LoadScene("Level 1");
                }

                else if (sceneName == "Level 4")
                {
                    SceneManager.LoadScene("Level 2");
                }
                if (sceneName == "Level 1")
                {
                    SceneManager.LoadScene("Level 3");
                }

                else if (sceneName == "Level 2")
                {
                    SceneManager.LoadScene("Level 4");
                }
            }
        }
    }
}
