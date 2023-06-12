using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrashDrink : MonoBehaviour
{
    [SerializeField] GameObject GamePanel;
    [SerializeField] GameObject cupObject;
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
        playerController = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerController>();
        drinkController = GameObject.FindGameObjectWithTag("Script Home").GetComponent<DrinkController>();
    }

    // Public function that uses the DrinkController's zero function to reset drink
    public void ThrowDrinkAway()
    {
        drinkController.TrashDrink();
        // Debug function
        // drinkController.CheckDrink();
        // Play sound here to signify completion
        PressButtonPanelClose();
        
    }
}
