using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class Topping : MonoBehaviour, IBeginDragHandler, IDragHandler, IEndDragHandler
{
    [HideInInspector] public Transform parentAfterDrag;
    [HideInInspector] public Transform parentBeforeDrag;
    public Image image;
    public AudioSource clip;

    public void OnBeginDrag(PointerEventData eventData)
    {
        // Debug.Log("Begin Drag");
        // Grab the containers to be used as
        // 1) a reset point if the item is not dropped into a slot
        // 2) a reference point to spawn other items for replayability
        parentBeforeDrag = transform.parent;
        parentAfterDrag = transform.parent;
        // Set the root of the item dragged to the same level as the minigame (temporarily)
        transform.SetParent(transform.root);
        transform.SetAsLastSibling();
        // Turn off raycast to prevent blocking the mouse's raycast
        image.raycastTarget = false;
    }

    public void OnDrag(PointerEventData eventData)
    {
        // Debug.Log("Dragging");
        // Make the item follow the mouse's position as its being dragged
        transform.position = Input.mousePosition;
        //Play Sound Here
        clip.Play();
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        // Debug.Log("End Drag");
        // Drop the item when we let go of left-click. Reset its point if its not in a slot
        transform.SetParent(parentAfterDrag);
        // Re-enable raycast
        image.raycastTarget = true;
    }
}
    
