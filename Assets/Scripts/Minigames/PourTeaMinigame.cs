using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using Boba;

public class PourTeaMinigame : MonoBehaviour
{
    [SerializeField] GameObject GamePanel;
    private PlayerController playerController;
    private DrinkController drinkController;
    TeaTypes tea;

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

    public void PourTea()
    {
        // Debug.Log("Minigame Start!");
        string buttonName = EventSystem.current.currentSelectedGameObject.name;
        switch (buttonName)
        {
            case "BlackTea_Button":
                Debug.Log("I poured black tea");
                tea = TeaTypes.BlackTea;
                break;
            case "GreenTea_Button":
                Debug.Log("I poured green tea");
                tea = TeaTypes.GreenTea;
                break;
            case "OolongTea_Button":
                Debug.Log("I poured oolong tea");
                tea = TeaTypes.OolongTea;
                break;
            default:
                Debug.Log("Tea not found");
                break;
        }   
        // Debug.Log("Wait Start");
        StartCoroutine(WaitButtonPressed());
        drinkController.AddIngredient(tea);
    }

    IEnumerator WaitButtonPressed()
    {
        yield return new WaitForSeconds(5);
        // Debug.Log("You've waited 5 seconds.");
        drinkController.CheckDrink();
        PressButtonPanelClose();
    }
}
