/*

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

/* THIS AND THE COLLECTIBLES SCRIPT ARE THE SAME FILE, THIS IS JUST A REFERENCE 
- Use original character sprite renderer
- Put in the sprite you want to change it to
- Input the threshold


****ATTACH TO THE CHARACTER AND THE COLLECTIBLES***

public class TRANSFORMATION : MonoBehaviour
 {
    private int fish = 0;

    [SerializeField] private TMP_Text CollectCount;
    [SerializeField] private SpriteRenderer characterSpriteRenderer;
    [SerializeField] private Sprite newCharacterSprite;
    [SerializeField] private int spriteChangeThreshold = 20;

    private void OnTriggerEnter2D(Collider2D collision) { 
        if (collision.gameObject.CompareTag("Collect")) { 
            Destroy(collision.gameObject);
            fish++;
            CollectCount.text = "Fish: " + fish;
        }

        if (fish >= spriteChangeThreshold) { 
            if (fish >= spriteChangeThreshold) { 
                characterSpriteRenderer.sprite = newCharacterSprite;
            }
        }
    }
}
*/