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
        minigame = GameObject.Find("Ice_MG").GetComponent<IceMinigame>();
    }
    public void OnDrop(PointerEventData eventData)
    {
        if (transform.childCount == 0)
        {
            GameObject dropped = eventData.pointerDrag;
            Topping topping = dropped.GetComponent<Topping>();

            // Place the item into the empty slot
            topping.parentAfterDrag = transform;
            Debug.Log("Successfully dropped");
            Destroy(dropped);
            // Spawn another item
            GameObject childObject = Instantiate(newIcePrefab);
            // Move that item into the slot from before
            childObject.transform.parent = topping.parentBeforeDrag.transform;
            minigame.iceCount++;
        }
    }
}
