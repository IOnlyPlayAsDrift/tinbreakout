using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.SceneManagement;

public class swapsprites : MonoBehaviour
{

    PolygonCollider2D coll;
    public static bool websteam = true;
    Scene m_Scene;
    string sceneName;


    // Start is called before the first frame update
    void Start()
    {
        coll = GetComponent<PolygonCollider2D>();
        m_Scene = SceneManager.GetActiveScene();
        sceneName = m_Scene.name;
    }

    // Update is called once per frame
    private void OnMouseDown()
    {
        if (Input.GetMouseButtonDown(0))
        {
            if (sceneName == "Level 3")
            {
                //websteam = false;
                SceneManager.LoadScene("Level 4");
            }

            else if (sceneName == "Level 1")
            {
                //websteam = false;
                SceneManager.LoadScene("Level 2");
            }
            else if (sceneName == "Level 2")
            {
                //websteam = true;
                SceneManager.LoadScene("Level 1");
            }
            else if (sceneName == "Level 4")
            {
                //websteam = true;
                SceneManager.LoadScene("Level 3");
            }
        }
    }
}
