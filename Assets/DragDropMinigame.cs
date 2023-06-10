using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class DragDropMinigame : MonoBehaviour
{
    [SerializeField] GameObject GamePanel;
    [SerializeField] public GameObject player;
    public static Player_Controller playerController;

    public void PressButtonPanelClose()
    {
        GamePanel.SetActive(false);
    }

    void OnEnable()
    {
        playerController = GameObject.FindGameObjectWithTag("Player").GetComponent<Player_Controller>();
        playerController.canMove = false;
        playerController.interactionBinding.Disable();
    }

    void OnDisable()
    {
        playerController.canMove = true;
        playerController.interactionBinding.Enable();
    }
}
