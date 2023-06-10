using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class DragDropMinigame : MonoBehaviour
{
    [SerializeField] GameObject GamePanel;
    
    public void PressButtonPanelClose()
    {
        GamePanel.SetActive(false);
    }

    void OnEnable()
    {
        // Spawn the toppings in their boxes

        // Check if the correct topping went into the drink

        // Close window if correct.
        // GamePanel.SetActive(false);
    }
}
