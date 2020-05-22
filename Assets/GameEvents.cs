using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameEvents : MonoBehaviour
{

    public static int score = 0;
    public static GameEvents current;

    private void Awake()
    {
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
