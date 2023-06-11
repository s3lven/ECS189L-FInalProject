using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlendMinigame : MonoBehaviour
{
    [SerializeField] GameObject GamePanel;
    private PlayerController playerController;
    private DrinkController drinkController;

    public void PressButtonPanelClose()
    {
        GamePanel.SetActive(false);
    }

    void OnEnable()
    {
        playerController.StopPlayer();
    }

    void OnDisable()
    {
        playerController.RestartPlayer();
    }

    void Awake()
    {
        this.drinkController = GameObject.FindGameObjectWithTag("Script Home").GetComponent<DrinkController>();
        playerController = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerController>();
    }

    public void BlendDrink()
    {
        // Play animation here to blend
        StartCoroutine(WaitButtonPressed());
        drinkController.BlendUp();
    }

    IEnumerator WaitButtonPressed()
    {
        yield return new WaitForSeconds(5);
        Debug.Log("Drink is blended!");
        // Play sound here to signify completion
        // drinkController.CheckDrink();
        PressButtonPanelClose();
    }
}
