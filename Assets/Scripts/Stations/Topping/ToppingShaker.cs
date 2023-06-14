using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class ToppingShaker : MonoBehaviour, IDropHandler
{
    [SerializeField] GameObject bobaTopping;
    [SerializeField] GameObject lycheeJellyTopping;
    private ToppingsMinigame toppingsMinigame;
    private GameObject toppingPrefab;

    void Start()
    {
        toppingsMinigame = GameObject.Find("Toppings_MG").GetComponent<ToppingsMinigame>();
    }

    public void OnDrop(PointerEventData eventData)
    {        
        if (transform.childCount == 0)
        {
            // Grab the object and its script (to access public member)
            GameObject dropped = eventData.pointerDrag;
            Topping topping = dropped.GetComponent<Topping>();

            if (dropped.transform.name == "Boba_Topping")
            {
                toppingPrefab = bobaTopping;
            }
            else if (dropped.transform.name == "LycheeJelly_Topping")
            {
                toppingPrefab = lycheeJellyTopping;
            }

            // Place the item into the empty slot instead of resetting to original slot
            topping.parentAfterDrag = transform;
            // Spawn another item for replayability
            GameObject childObject = Instantiate(toppingPrefab);
            // Move that spawned item into the slot from before
            childObject.transform.parent = topping.parentBeforeDrag.transform;
            toppingsMinigame.isToppingLoaded = true;
        }
    }
}
