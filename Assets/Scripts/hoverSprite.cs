using UnityEngine;
using UnityEngine.UI;

public class ImageHover : MonoBehaviour
{
    public Image image;
    public Sprite hoverSprite;
    public Sprite normalSprite;

    public void OnPointerEnter()
    {
        image.sprite = hoverSprite; // Change the sprite to the hover sprite
    }

    public void OnPointerExit()
    {
        image.sprite = normalSprite;// Change the sprite back to default
    }
}