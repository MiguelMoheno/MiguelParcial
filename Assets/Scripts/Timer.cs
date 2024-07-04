using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public TextMeshProUGUI timer;
    private float time = 0f;
    private bool running = true;

    void Start()
    {
        
        running = true;
    }

    void Update()
    {
        if (running)
        {
            time += Time.deltaTime;
            UpdateTimerText();
        }
    }

    void UpdateTimerText()
    {
        timer.text = "Time: " + time.ToString("F2");
    }

    public void StopTimer()
    {
        running = false;
    }
}
