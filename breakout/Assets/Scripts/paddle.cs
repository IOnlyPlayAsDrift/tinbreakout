using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class paddle : MonoBehaviour
{
    private float startPosX;
    private bool isBeingHeld = false;
    bool hasStarted = false;

    [SerializeField] float minX = -2.8f;
    [SerializeField] float maxX = 2.8f;

    private void Start()
    {
        gameObject.tag = "Paddle";
    }

    // Update is called once per frame
    void Update()
    {
        if (isBeingHeld == true)
        {
            if (!hasStarted)
            {
                FindObjectOfType<Ball>().LaunchOnMouseClick();
                FindObjectOfType<stopwatch>().timerButton();
                hasStarted = true;
            }
            Vector2 mousePos;
            mousePos = Input.mousePosition;
            mousePos = Camera.main.ScreenToWorldPoint(mousePos);
            mousePos.x = Mathf.Clamp(mousePos.x, minX, maxX);
            //mousePos.x = Mathf.Clamp(GetXPos(), minX, maxX);
            this.gameObject.transform.localPosition = new Vector2(mousePos.x, -4);
        }

        //if (hasStarted == true)
        //{
        //    FindObjectOfType<stopwatch>().StopWatchCalcul();
        //}
    }

    private void OnMouseDown()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Vector2 mousePos;
            mousePos = Input.mousePosition;
            mousePos = Camera.main.ScreenToWorldPoint(mousePos);
            isBeingHeld = true;
        }
    }

    private void OnMouseUp()
    {
        isBeingHeld = false;
    }

    /*private float GetXPos()
    {
        if (FindObjectOfType<GameStatus>().IsAutoPlayEnabled())
        {
            return FindObjectOfType<Ball>().transform.position.x;
        }
        else
        {
            Vector2 mousePos;
            return Input.mousePosition;
        }
    }*/
}
