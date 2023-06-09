using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Topping : MonoBehaviour
{
    private bool dragging;
    
    void Update()
    {
        
    }
    void OnMouseDown() {
        dragging = true;
        Debug.Log("Draggin!");
    }
}
