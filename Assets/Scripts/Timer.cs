using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Timer : MonoBehaviour
{
    public Slider timerSlider;
    public TMPro.TextMeshProUGUI timerText;
    
    public Image fill;
    public Color MaxTimeColor = Color.green;
    public Color MinTimeColor = Color.red;
    public float gameTime;
    private bool stopTimer;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("run timer");
        stopTimer = false;
        // Set max game time for timer
        timerSlider.maxValue = gameTime;
        timerSlider.value = gameTime;
    }

    public void Restart()
    {
        Debug.Log("restarted timer");
        stopTimer = false;
        // Set max game time for timer
        timerSlider.maxValue = gameTime;
        timerSlider.value = gameTime;
    }

    // Update is called once per frame
    void Update()
    {
        float time = gameTime - Time.timeSinceLevelLoad;

        // Convert to minutes:seconds format
        int minutes = Mathf.FloorToInt(time/60);
        int seconds = Mathf.FloorToInt(time-minutes * 60f);

        string textTime = string.Format("{0:0}:{1:00}", minutes, seconds);

        // stops timer once time's up
        if (time <= 0)
        {
            stopTimer = true;
        }

        // update timer slider
        if (!stopTimer)
        {
            timerText.text = textTime;
            timerSlider.value = time;
            fill.color = Color.Lerp(MinTimeColor, MaxTimeColor, (float)timerSlider.value / gameTime);
        }
    }
}
