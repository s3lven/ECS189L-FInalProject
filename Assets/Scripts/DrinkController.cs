using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Boba;

public class DrinkController : MonoBehaviour
{
    // All stats that are tracked within a drink
    public TeaTypes _tea;
    public ToppingsType _topping;
    public SyrupPowderType _syrupPowder;
    public SyrupPowderType _milk;
    public bool  _isIceAdded;
    public bool _isShakenUp;
    public bool _isBlendedUp;

    public bool _isTeaAdded;
    public bool _isToppingAdded;
    public bool _isSyrupPowderAdded;
    public bool _isMilkAdded;

    void Awake()
    {
        // Zero all parameters
        _tea = TeaTypes.None;
        _topping = ToppingsType.None; 
        _syrupPowder = SyrupPowderType.None;
        _milk = SyrupPowderType.None;
        _isIceAdded = false;
        _isShakenUp = false;
        _isBlendedUp = false;

        _isTeaAdded = false;
        _isToppingAdded = false;
        _isSyrupPowderAdded = false;
        _isMilkAdded = false;
        
    }

    // Check for what type of ingredient is being sent (if it is a tea topping or syrup)
    public void AddIngredient(object ingredient)
    {
        switch (ingredient)
        {
            case TeaTypes tea:
                _tea = tea;
                break;
            case ToppingsType topping:
                _topping = topping;
                break;
            case SyrupPowderType syrupPowder:
                // Because the station includes both milk and sugar, and both are being tracked separtely,
                // we need to check if it is one or the other
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
                // Boolean cases are checked at different functions
                break;
        }
    }

    // Public setters that are accessed by minigame scripts
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

    // A debug function.
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

    // Zeroes the entire drink to represent it being thrown away
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

    public string EncodeDrink()
    {
        var _isIceAddedEncoding = _isIceAdded ? 1 : 0;
        var _isShakenUpEncoding = _isShakenUp ? 1 : 0;
        var _isBlendedUpEncoding = _isBlendedUp ? 1 : 0;

        var message = ((int)_tea).ToString() +
            ((int)_topping).ToString() +
            ((int)_syrupPowder).ToString() +
            ((int)_milk).ToString() +
            _isIceAddedEncoding +
            _isShakenUpEncoding +
            _isBlendedUpEncoding;
        Debug.Log(message);

        return message;
    }

}

