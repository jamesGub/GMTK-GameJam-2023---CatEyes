using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Collectibles : MonoBehaviour
 {
    private int fish = 0;

    [SerializeField] private TMP_Text CollectCount;

    private void OnTriggerEnter2D(Collider2D collision) { 
        if (collision.gameObject.CompareTag("Collect")) { 
            Destroy(collision.gameObject);
            fish++;
            CollectCount.text = "Fish: " + fish;

        
        }
    }
}
