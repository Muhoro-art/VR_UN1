using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToggleActiveState : MonoBehaviour
{
    // This public variable can be set from the Unity inspector
    public GameObject objectToToggle;

    // This method toggles the active state of the object
    public void Toggle()
    {
        // Check if the object is not null to avoid errors
        if (objectToToggle != null)
        {
            // This line toggles the active state
            objectToToggle.SetActive(!objectToToggle.activeSelf);
        }
    }
}
