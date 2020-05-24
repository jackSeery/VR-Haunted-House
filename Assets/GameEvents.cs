using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using Valve.Newtonsoft.Json;

public class GameEvents : MonoBehaviour
{

    public static int score = 0;
    public static GameEvents current;
    public static IObserver<Type> observer;

    private void Awake()
    {
        Debug.Log("Script GameEvents.cs is Awake");
        current = this;
    }

    public event Action onPinFall;
    public void PinFall()
    {
        if(onPinFall != null)
        {
            onPinFall();
        }
    }
}
