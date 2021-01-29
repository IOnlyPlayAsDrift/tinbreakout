using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.UI;

public class GameStatus : MonoBehaviour
{

    //[Range(0.5f, 0.5f)] [SerializeField] float gameSpeed = .5f;

    [SerializeField] int score = 1000;
    [SerializeField] int pointsPerBrick = 100;
    [SerializeField] private Text text;
    [SerializeField] bool isAutoPlayEnabled;

    private void Start()
    {
        text.text = score.ToString();
    }

    public void AddToScore()
    {
        score += pointsPerBrick;
    }

    // Update is called once per frame
    void Update()
    {
        Time.timeScale = 1.00f;
        text.text = score.ToString();
    }

    public void ResetGame()
    {
        Destroy(gameObject);
    }
    public bool IsAutoPlayEnabled()
    {
        return isAutoPlayEnabled;
    }
}
