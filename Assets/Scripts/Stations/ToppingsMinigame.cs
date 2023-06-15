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
    public bool isToppingLoaded;
    public AudioSource clip;

    public void PressButtonPanelClose()
    {
        GamePanel.SetActive(false);
    }

    void OnEnable()
    {
        playerController.StopPlayer();
        if (drinkController._isToppingAdded)
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
        playerController = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerController>();
        this.drinkController = GameObject.FindGameObjectWithTag("Script Home").GetComponent<DrinkController>();
        isToppingLoaded = false;
    }

    void Update()
    {
        // Stop the game from re-running if the topping is already loaded in the drink
        //  the "don't insert any more ingredients because they've already added it" needs to be consistent with all ingredients
        if(isToppingLoaded)
        {
           CheckTopping();
           
        }
    }

    void CheckTopping()
    {
        // Grab the name of the object the topping came from. 
        var objectName = cupObject.transform.GetChild(0).name;
        isToppingLoaded = true;

        switch (objectName)
        {
            case "Boba_Topping":
                toppings = ToppingsType.Boba;
                clip.Play();
                break;
            case "LycheeJelly_Topping":
                toppings = ToppingsType.LycheeJelly;
                clip.Play();
                break;
            default:
                Debug.Log("There is no topping called " + objectName);
                break;
        }

        Destroy(cupObject.transform.GetChild(0).gameObject);

        Debug.Log("Topping sent: " + toppings);
        // Assign the topping in the controller
        drinkController.AddIngredient(toppings);
        // Play sound here to signify completion
        // Debug function 
        // drinkController.CheckDrink();
        isToppingLoaded = false;
        PressButtonPanelClose();
    }


}
