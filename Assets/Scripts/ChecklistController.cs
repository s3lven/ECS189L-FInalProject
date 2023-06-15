using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Boba;

public class ChecklistController : MonoBehaviour
{
    public TMPro.TextMeshProUGUI drinkNameText;
    public OrderController orderController;
    public DrinkController drinkController;
    
    void Start()
    {
        orderController = GameObject.FindGameObjectWithTag("Script Home").GetComponent<OrderController>();
        drinkController = GameObject.FindGameObjectWithTag("Script Home").GetComponent<DrinkController>();
    }

    // Update is called once per frame
    void Update()
    {
        setDrinkName();
    }

    void setDrinkName()
    {
        // Check the order,
        // List whatever tea it is {Black/Jasmine/Oolong}
        string teaName = "";
        switch (orderController.orderTea)
        {
            case TeaTypes.BlackTea:
                teaName = "Black";
                break;
            case TeaTypes.GreenTea:
                teaName = "Jasmine";
                break;
            case TeaTypes.OolongTea:
                teaName = "Oolong";
                break;
            default:
                Debug.Log("No tea found for the checklist");
                break;
        }

        // List whatever topping is in there {Boba/LycheeJelly}
        string toppingName = "";
        switch (orderController.orderToppings)
        {
            case ToppingsType.None:
                toppingName = "";
                break;
            case ToppingsType.Boba:
                toppingName = "Boba,";
                break;
            case ToppingsType.LycheeJelly:
                toppingName = "Lychee Jelly,";
                break;
            default:
                Debug.Log("No topping found for the checklist");
                break;

        }
        // List if there's any sugar and/or milk
        string sugarName = (orderController.orderSugar != SyrupPowderType.None) ? "Sugar" : "";
        string milkName = (orderController.orderMilk == SyrupPowderType.None) ? "" : "with Milk";
        // List if there's ice in there
        string iceName = orderController.orderIce ? "Iced" : "";
        // List if it is blended or shaken
        string blendShakeName = orderController.orderShaked ? "Shaken" : "Blended";
        // Example: Jasmine Milk Tea with Sugar, Boba, No Ice, and Shaken
        // Example: Oolong Tea with No Sugar, Lychee Jelly, Iced, and Blended

        string drinkName = string.Format("{0} Tea\n{1}\n{2}\n{3}\n{4}\n{5}",
            teaName, milkName, sugarName, toppingName, iceName, blendShakeName);
        drinkNameText.text = drinkName;
    }
}
