using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interactable : MonoBehaviour
{
    public float xAngle, yAngle, zAngle;

    public void OnInteraction()
    {
        
        this.transform.Rotate(0,25, 0, Space.World);
        Debug.Log("Rotated!");
        
    }
  
}
