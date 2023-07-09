using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Speedometer : MonoBehaviour
{
    public Rigidbody2D CatBall;
    public TMP_Text speedText;
    
    private void Update()
    {

        float speed = CatBall.velocity.magnitude;

        speedText.text = "Speed: " + speed.ToString("F1");

        
    }
}
