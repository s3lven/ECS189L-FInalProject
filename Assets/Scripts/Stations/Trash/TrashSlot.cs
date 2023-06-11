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
        minigame = GameObject.Find("Trash_MG").GetComponent<TrashDrink>();
    }
    public void OnDrop(PointerEventData eventData)
    {
        if (transform.childCount == 0)
        {
            GameObject dropped = eventData.pointerDrag;
            Topping topping = dropped.GetComponent<Topping>();

            // Place the item into the empty slot
            topping.parentAfterDrag = transform;
            // Debug.Log("Successfully dropped");
            Destroy(dropped);
            // Spawn another item
            GameObject childObject = Instantiate(newIcePrefab);
            // Replace item for replayability
            childObject.transform.parent = topping.parentBeforeDrag.transform;
            // Close Panel
            minigame.ThrowDrinkAway();
        }
    }
}