using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fishies : MonoBehaviour
{
    public Sprite[] animationFrames;   // Array of animation frames
    public float animationSpeed = 0.2f; // Speed of the animation

    private SpriteRenderer spriteRenderer;
    private int currentFrameIndex = 0;
    private float timer = 0f;

    private void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    private void Update()
    {
        timer += Time.deltaTime;

        // Check if it's time to advance to the next frame
        if (timer >= animationSpeed)
        {
            timer = 0f;

            // Update the sprite to the next frame
            currentFrameIndex = (currentFrameIndex + 1) % animationFrames.Length;
            spriteRenderer.sprite = animationFrames[currentFrameIndex];
        }
    }
}
