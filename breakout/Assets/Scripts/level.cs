using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class level : MonoBehaviour
{

    [SerializeField] int breakableBlocks;

    SceneLoader sceneloader;

    private void Start()
    {
        sceneloader = FindObjectOfType<SceneLoader>();
    }

    public void CountBreakableBlocks()
    {
        breakableBlocks++;
    }

    public void BlockDestroyed()
    {
        breakableBlocks--;
        if (breakableBlocks <= 0)
        {
            FindObjectOfType<stopwatch>().timerButton();
            FindObjectOfType<Ball>().DestroyBall();
            FindObjectOfType<sparkles>().Sparkles();
            //FindObjectOfType<cup>().Cup();
        }
    }
}
