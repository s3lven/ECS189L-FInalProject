using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Boba;

public class DragDropMinigame : MonoBehaviour
{
    [SerializeField] GameObject GamePanel;
    public static Player_Controller playerController;

    [SerializeField] GameObject cupObject;
    ToppingsType toppings;

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

    void Update()
    {
        if(cupObject.transform.childCount() > 0)
        {
            var objectName = cupObject.transform.name;

            switch (objectName)
            {
                case "Boba_Topping":
                    toppings = TeaTypes.Boba;
                    break;
                case "LycheeJelly_Topping":
                    toppings = TeaTypes.LycheeJelly;
                    break;
                case "GrassJelly_Topping":
                    toppings = TeaTypes.GrassJelly_Topping;
                    break;
                default
                    Debug.Log("There is no topping called " + objectName);
                    break;
            }
        }
    }


}
