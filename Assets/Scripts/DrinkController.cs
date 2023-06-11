using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Boba;

public class DrinkController : MonoBehaviour
{
    public static TeaTypes _tea;
    public static ToppingsType _topping;
    public static SyrupPowderType _syrupPowder;
    public static SyrupPowderType _milk;
    public static bool  _isIceAdded;
    public static bool _isShakenUp;
    public static bool _isBlendedUp;

    void Awake()
    {
        _tea = TeaTypes.None;
        _topping = ToppingsType.None; 
        _syrupPowder = SyrupPowderType.None;
        _milk = SyrupPowderType.None;
        _isIceAdded = false;
        _isShakenUp = false;
        _isBlendedUp = false;
        
    }

    public void AddIngredient(object ingredient)
    {
        // Debug.Log("Received Ingredient: " + ingredient);
        switch (ingredient)
        {
            case TeaTypes tea:
                _tea = tea;
                break;
            case ToppingsType topping:
                _topping = topping;
                break;
            case SyrupPowderType syrupPowder:
                if(syrupPowder == SyrupPowderType.Milk)
                {
                    _milk = syrupPowder;
                }
                else if (syrupPowder == SyrupPowderType.Sugar)
                {
                    _syrupPowder = syrupPowder;
                }
                break;
            case bool:
                break;
        }
        // Debug.Log("Added Ingredient: " + ingredient);
    }

    public void AddIce()
    {
        _isIceAdded = true;
    }
    
    public void ShakeUp()
    {
        _isShakenUp = true;
    }

    public void BlendUp()
    {
        _isBlendedUp = true;
    }

    // Function to check if all the procedures are performed on the drink
    // Given a recipe
    public void CheckDrink()
    {
        Debug.Log("Drink Controller Tea: " + _tea);
        Debug.Log("Drink Controller Topping: " + _topping);
        Debug.Log("Drink Controller Syrup Powder: " + _syrupPowder);
        Debug.Log("Drink Controller Milk: " + _milk);
        Debug.Log("Drink Controller Ice: " + _isIceAdded);
        Debug.Log("Drink Controller Shaked: " + _isShakenUp);
        Debug.Log("Drink Controller Blended: " + _isBlendedUp);
    }

    public void TrashDrink()
    {
        _tea = TeaTypes.None;
        _topping = ToppingsType.None;
        _syrupPowder = SyrupPowderType.None;
        _milk = SyrupPowderType.None;
        _isIceAdded = false;
        _isShakenUp = false;
        _isBlendedUp = false;
    }

}
