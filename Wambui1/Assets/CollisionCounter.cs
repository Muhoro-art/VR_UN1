using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro; // Use this namespace to work with TextMeshPro

public class CollisionCounter : MonoBehaviour
{
    public TextMeshProUGUI collisionCounterText; // Change to TextMeshProUGUI

    private int collisionCount = 0;   // Counter for collisions

    void OnCollisionEnter(Collision collision)
    {
        collisionCount--; // Decrease the counter on collision
        UpdateCounterText();
    }

    void Start()
    {
        UpdateCounterText(); // Initialize the text on start
    }

    void UpdateCounterText()
    {
        // Update the UI text with the current counter value
        collisionCounterText.text = "Collisions: " + collisionCount.ToString();
    }
}
