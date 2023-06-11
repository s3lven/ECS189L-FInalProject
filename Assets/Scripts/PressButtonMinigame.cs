using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PressButtonMinigame : MonoBehaviour
{
    [SerializeField] GameObject GamePanel;

    public void PressButtonPanelClose()
    {
        GamePanel.SetActive(false);
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
