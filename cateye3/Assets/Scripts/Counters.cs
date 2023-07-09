using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Counters : MonoBehaviour
{
    public static Counters instance;
    public int currentCount = 0;
    public TMP_Text counterText;

    private void Awake()
    {
        instance = this;
    }

    public void IncrementCounter(int value)
    {
        currentCount += value;
        // Update the counter text
        // You can use any method to display the counter value (e.g., UI text, TextMesh, etc.)
        Debug.Log("Current Count: " + currentCount);
        // Example of updating a TextMesh component
        if (counterText != null)
        {
            counterText.text = currentCount.ToString();
        }
    }
}
