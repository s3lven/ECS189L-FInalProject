using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using Boba;

public class PressButtonMinigame : MonoBehaviour
{
    
    [SerializeField] GameObject GamePanel;
    Player_Controller playerController;

    private DrinkController drinkController;
    TeaTypes tea;

    void Awake()
    {
        this.drinkController = GameObject.FindGameObjectWithTag("Script Home").GetComponent<DrinkController>();
    }
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
        string buttonName = EventSystem.current.currentSelectedGameObject.name;
        switch (buttonName)
        {
            case "BlackTeaButton":
                Debug.Log("I poured black tea");
                tea = TeaTypes.BlackTea;
                break;
            case "GreenTeaButton":
                Debug.Log("I poured green tea");
                tea = TeaTypes.GreenTea;
                break;
            case "OolongTeaButton":
                Debug.Log("I poured oolong tea");
                tea = TeaTypes.OolongTea;
                break;
            default:
                Debug.Log("Tea not found");
                break;
        }   
        Debug.Log("Wait Start");
        StartCoroutine(WaitButtonPressed());
        drinkController.AddIngredient(tea);
    }

    IEnumerator WaitButtonPressed()
    {
        yield return new WaitForSeconds(5);
        Debug.Log("You've waited 5 seconds.");
        drinkController.CheckDrink();
        PressButtonPanelClose();
    }
}
