using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DragDropMinigame : MonoBehaviour
{
    [SerializeField] GameObject GamePanel;

    public void PressButtonPanelClose()
    {
        GamePanel.SetActive(false);
    }
}
