using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PressButtonMinigame : MonoBehaviour
{
    [SerializeField] GameObject GamePanel;
    [SerializeField] public GameObject player;
    Player_Controller playerController;

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

    public void PressWaitButton()
    {
        Debug.Log("Minigame Start!");
        StartCoroutine(WaitButtonPressed());
    }
    IEnumerator WaitButtonPressed()
    {
        yield return new WaitForSeconds(5);
        Debug.Log("You've waited 5 seconds.");
        PressButtonPanelClose();
    }
}
