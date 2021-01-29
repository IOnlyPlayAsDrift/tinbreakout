using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class stopwatch : MonoBehaviour
{

    //public float timeStart;
    bool timerActive = false;
    public float time;
    private float Timer;
    private float fixedDeltaTime;

    [SerializeField] Text TimerText;

    private void Awake()
    {
        this.fixedDeltaTime = Time.fixedDeltaTime;
    }

    void Update()
    {
        if (timerActive == true)
        {
            Time.timeScale = 1.0f;
            Time.fixedDeltaTime = this.fixedDeltaTime * Time.timeScale;
            Timer += Time.deltaTime;
            int minutes = Mathf.FloorToInt(Timer / 60f);
            int seconds = Mathf.FloorToInt(Timer % 60f);
            int milliseconds = Mathf.FloorToInt((Timer * 1000f) % 1000f);
            TimerText.text = minutes.ToString("00") + ":" + seconds.ToString("00") + "." + milliseconds.ToString("000");
        }

    }

    public void timerButton()
    {
        timerActive = !timerActive;
    }

    //public void SaveScore()
    //{
    //    PlayerPrefs.SetFloat("score", )
    //}
}
