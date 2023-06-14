using UnityEngine;
using UnityEngine.UI;

public class ImageSwitcher : MonoBehaviour
{
    public Sprite[] sprites; // Array of sprites to switch between
    private int currentIndex = 0; // Current index of the displayed sprite
    private Image imageComponent; // Reference to the Image component on the object

    private void Start()
    {
        imageComponent = GetComponent<Image>();
        // Set the initial sprite
        if (sprites.Length > 0)
        {
            imageComponent.sprite = sprites[currentIndex];
        }
    }

    public void SwitchImage()
    {
        // Increment the index or wrap around if it exceeds the array length
        currentIndex = (currentIndex + 1) % sprites.Length;
        // Update the image sprite
        imageComponent.sprite = sprites[currentIndex];
    }
}
