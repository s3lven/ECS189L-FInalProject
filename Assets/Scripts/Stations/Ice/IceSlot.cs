using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class IceSlot : MonoBehaviour, IDropHandler
{
    [SerializeField] GameObject newIcePrefab;
    private IceMinigame minigame;

    void Start()
    {
        // Grab the associated minigame to use its functions
        minigame = GameObject.Find("Ice_MG").GetComponent<IceMinigame>();
    }
    public void OnDrop(PointerEventData eventData)
    {
        // Debug.Log("Dropped" + eventData.pointer);
        // If the slot its dropped on has no items in it
        if (transform.childCount == 0 && transform.name == "Ice_Cup")
        {
            // Grab the script and object of the dropped item
            GameObject dropped = eventData.pointerDrag;
            Topping topping = dropped.GetComponent<Topping>();

            // Place the item into the empty slot instead of being reset to its original point 
            topping.parentAfterDrag = transform;
            // Debug.Log("Successfully dropped");
            // Destroy the object for replayability
            Destroy(dropped);
            // Spawn another item for replayability
            GameObject childObject = Instantiate(newIcePrefab);
            // Move that spawned item into the slot from before
            childObject.transform.parent = topping.parentBeforeDrag.transform;
            // Increase the ice count for the minigame
            minigame.iceCount++;
        }
    }
}
