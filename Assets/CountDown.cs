﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CountDown : MonoBehaviour
{
    [SerializeField]
    private int startCountdown = 60;

    [SerializeField]
    Text TxtTimer;

    void Start()
    {
        StartCoroutine(Pause());
    }

   IEnumerator Pause()
    {
        while(startCountdown > 0)
        {
            yield return new WaitForSeconds(1f);
            startCountdown--;
            TxtTimer.text = "Timer : " + startCountdown;
        }

        Debug.Log("GAME OVER");
    }
}
