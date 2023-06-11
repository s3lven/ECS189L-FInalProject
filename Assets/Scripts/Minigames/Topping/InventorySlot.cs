using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class InventorySlot : MonoBehaviour, IDropHandler
{
    [SerializeField] GameObject newIcePrefab;
    public void OnDrop(PointerEventData eventData)
    {
        if (transform.childCount == 0) 
        {
            GameObject dropped = eventData.pointerDrag;
            Topping topping = dropped.GetComponent<Topping>();

            // Place the item into the empty slot
            topping.parentAfterDrag = transform;
            //Destroy(dropped);
            // Spawn another item
            // GameObject childObject = Instantiate(newIcePrefab);
            // childObject.transform.parent = topping.parentAfterDrag.transform;

        }
    }
}
