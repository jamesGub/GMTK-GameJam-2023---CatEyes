using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Slides : MonoBehaviour
{

        public Sprite[] comicStills;
        public float displayTime = 2f;
        public Image imageComponent;
        private int currentIndex = 0;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(PlaySlideshow());


    }

    private IEnumerator PlaySlideshow() { 
        while (currentIndex < comicStills.Length) { 
            imageComponent.sprite = comicStills[currentIndex];
            yield return new WaitForSeconds(displayTime);
            currentIndex++;

        }
    }
}
