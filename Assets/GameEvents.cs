using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using Valve.Newtonsoft.Json;

public class GameEvents : MonoBehaviour
{
    [SerializeField]
    public BallController ball;
    public static int score = 0;
    public static GameEvents current;
    private TextMeshProUGUI scoreText;

    private void Awake()
    {
        current = this;
    }

    private void Start()
    {
        Debug.Log("Script GameEvents.cs is Awake");
        scoreText = GetComponentInChildren<TextMeshProUGUI>();
        if(scoreText == null)
        {
            Debug.LogWarning("scoreText is null");
        }
        scoreText.text = "Score: " + score + "/55";
    }

    public void UpdateScore()
    {
        scoreText.text = "Score: " + score + "/55";
    }

    public event Action onPinFall;
    public void PinFall()
    {
        if(onPinFall != null)
        {
            onPinFall();
        }
    }

    public event Action onBallFall;
    public void BallFall()
    {
        if(onBallFall != null)
        {
            onBallFall();
        }
    }
}
