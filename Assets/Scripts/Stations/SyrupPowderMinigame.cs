using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using Boba;

public class SyrupPowderMinigame : MonoBehaviour
{
    [SerializeField] GameObject GamePanel;
    private PlayerController playerController;
    private DrinkController drinkController;
    SyrupPowderType syrupPowder;

    public void PressButtonPanelClose()
    {
        GamePanel.SetActive(false);
    }

    void OnEnable()
    {
        playerController.StopPlayer();
        if (drinkController._isSyrupPowderAdded && drinkController._isMilkAdded)
        {
            PressButtonPanelClose();
        }
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

    public void PourSyrupTea()
    {
        // Debug.Log("Minigame Start!");
        // Check which button is pressed and assign the ingredient
        string buttonName = EventSystem.current.currentSelectedGameObject.name;
        switch (buttonName)
        {
            case "Sugar_Button":
                Debug.Log("I poured sugar");
                syrupPowder = SyrupPowderType.Sugar;
                break;
            case "Milk_Button":
                Debug.Log("I poured milk");
                syrupPowder = SyrupPowderType.Milk;
                break;
            default:
                Debug.Log("Syrup or Powder not found");
                break;
        }
        // Debug.Log("Wait Start");
        StartCoroutine(WaitButtonPressed());
        // Add the ingredient in the controller
        drinkController.AddIngredient(syrupPowder);
    }

    IEnumerator WaitButtonPressed()
    {
        yield return new WaitForSeconds(5);
        // Debug.Log("Syrup/Powder poured");
        // Play sound here to signify completion
        // drinkController.CheckDrink();
        PressButtonPanelClose();
    }
}
