using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Timers : MonoBehaviour
{
    public TMP_Text timerText;
    public float startTime = 0f;

    private float currentTime = 0f;

    // Start is called before the first frame update
    void Start()
    {
        currentTime = startTime;    
    }

    // Update is called once per frame
    void Update()
    {
        currentTime += Time.deltaTime;

        string minutes = Mathf.Floor(currentTime / 60).ToString("00");
        string seconds = (currentTime % 60).ToString("00");

        timerText.text = minutes + ":" + seconds;

    }
}
