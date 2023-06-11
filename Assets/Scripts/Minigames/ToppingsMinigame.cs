using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Boba;

public class ToppingsMinigame : MonoBehaviour
{
    [SerializeField] GameObject GamePanel;
    [SerializeField] GameObject cupObject;
    private PlayerController playerController;
    private DrinkController drinkController;    
    ToppingsType toppings;
    bool isToppingLoaded;
    

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
        this.drinkController = GameObject.FindGameObjectWithTag("Script Home").GetComponent<DrinkController>();
        isToppingLoaded = false;
    }

    void Update()
    {
        if(cupObject.transform.childCount > 0 && !isToppingLoaded)
        {
           CheckTopping();
        }
    }

    void CheckTopping()
    {
        var objectName = cupObject.transform.GetChild(0).name;
        isToppingLoaded = true;

        switch (objectName)
        {
            case "Boba_Topping":
                toppings = ToppingsType.Boba;
                break;
            case "LycheeJelly_Topping":
                toppings = ToppingsType.LycheeJelly;
                break;
            case "GrassJelly_Topping":
                toppings = ToppingsType.GrassJelly;
                break;
            default:
                Debug.Log("There is no topping called " + objectName);
                break;
        }

        Debug.Log("Topping sent: " + toppings);
        drinkController.AddIngredient(toppings);
        drinkController.CheckDrink();
        PressButtonPanelClose();
    }


}
