using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class TrashSlot : MonoBehaviour, IDropHandler
{
    [SerializeField] GameObject newIcePrefab;
    private TrashDrink minigame;

    void Start()
    {
        // Grab the minigame that is related
        minigame = GameObject.Find("Trash_MG").GetComponent<TrashDrink>();
    }
    public void OnDrop(PointerEventData eventData)
    {
        // If the item is dropped in a slot with no items in it
        if (transform.childCount == 0)
        {
            // Take the item that is being dropped and the the script associated
            GameObject dropped = eventData.pointerDrag;
            Topping topping = dropped.GetComponent<Topping>();

            // Place the item into the empty slot by assigning the slot to the item's parent
            topping.parentAfterDrag = transform;
            // Debug.Log("Successfully dropped");
            // Destroy the item that is dropped (for the trash's case)
            Destroy(dropped);
            // Spawn another item for replayability
            GameObject childObject = Instantiate(newIcePrefab);
            // Replace item for replayability
            childObject.transform.parent = topping.parentBeforeDrag.transform;
            // Call the related function to fully trash the item
            minigame.ThrowDrinkAway();
        }
    }
}