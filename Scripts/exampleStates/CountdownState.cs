﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CountdownState : State
{
    public GameObject canvasObject;
    public Text textPane;
    public float countDownTimer;

    public override void OnEnable()
    {
        base.OnEnable();
        textPane.text = countDownTimer.ToString();
     
    }

	public void Update()
	{
        countDownTimer -= Time.deltaTime;
        textPane.text = countDownTimer.ToString("f0");

        if (countDownTimer < 0) advanceState();
    }
}