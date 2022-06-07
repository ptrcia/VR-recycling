using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public ScoreManager scoreManager;
    public float timer = 0;
    public float minNumber;
    public Text textTimer;
    public UnityEvent Fail;
    public UnityEvent Win;


    void Update()
    {
        timer -= Time.deltaTime;
        textTimer.text = "TIME LEFT: " + timer.ToString("f1");

        if (timer < 0 && scoreManager.number < minNumber) //a falta de concretar
        {
            timer = 0;
            Time.timeScale = 0;
            Fail.Invoke();
        }
        else if (timer < 0 && scoreManager.number > minNumber)
        {
            timer = 0;
            Time.timeScale = 0;
            Win.Invoke();
        }
    }
}
