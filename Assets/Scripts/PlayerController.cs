using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    // Components
    [SerializeField] Rigidbody rigidbody;
    Transform avatar;

    // Player Movement -- uses Unity's new Input System
    [SerializeField] public InputAction inputAction;
    [SerializeField] float movementSpeed;
    Vector2 movementInput;
    // Member used to disable movement
    public bool canMove;

    // Interaction
    [SerializeField] InputAction mouseBinding;
    [SerializeField] InputAction interactionBinding;
    [SerializeField] LayerMask interactLayer;
    Vector2 mousePositionInput;
    Camera camera;

    // Start is called before the first frame update
    void Start()
    {
        // Assign the sprite to the player so we can move it
        avatar = transform.GetChild(0);
        // Camera used to raycast on interactables
        camera = Camera.main;
        canMove = true;
        movementSpeed = 5;

    }

    private void Awake()
    {
        // Subscribe the function to the player object
        // On left click, use the Interact function
        interactionBinding.performed += Interact;
    }

    // Update is called once per frame
    void Update()
    {
        // Assign the scale to move the player
        movementInput = inputAction.ReadValue<Vector2>();
        if (movementInput.x != 0)
        {
            avatar.localScale = new Vector2(Mathf.Sign(movementInput.x), 1);
        }

        // Move the mouse
        mousePositionInput = mouseBinding.ReadValue<Vector2>();
    }

    void FixedUpdate()
    {
        if (this.canMove)
        {
            // Move the player
            rigidbody.velocity = movementInput * movementSpeed;
        }

    }

    private void OnEnable()
    {
        inputAction.Enable();
        mouseBinding.Enable();
        interactionBinding.Enable();
    }

    private void OnDisable()
    {
        inputAction.Disable();
        mouseBinding.Disable();
        interactionBinding.Disable();
    }

    // Allow the player to interact with objects with the mouse
    void Interact(InputAction.CallbackContext context)
    {
        if(context.phase == InputActionPhase.Performed)
        {
            RaycastHit hit;
            Ray ray = camera.ScreenPointToRay(mousePositionInput);
            if(Physics.Raycast(ray, out hit, interactLayer))
            {
                // Debug.Log("hit: " + hit.transform.name);
                if(hit.transform.tag == "Interactable")
                {
                    // Check if the highlight is on in the hierarachy
                    if (!hit.transform.GetChild(0).gameObject.activeInHierarchy)
                    {
                        return;
                    }
                    // Grab the interactable that is clicked on and open its panel
                    Interactable temp = hit.transform.GetComponent<Interactable>();
                    temp.PlayMiniGame();
                }

                if(hit.transform.tag == "Submit")
                {
                    // Check if the highlight is on in the hierarachy
                    if (!hit.transform.GetChild(0).gameObject.activeInHierarchy)
                    {
                        return;
                    }
                    // Grab the interactable that is clicked on and open its panel
                    Submit temp = hit.transform.GetComponent<Submit>();
                    temp.PlayMiniGame();
                }
            }
        }
    }

    // Stops the player from moving or interacting so the focus is on the minigame
    // Velocity set to 0 to prevent moving players to continue moving when interacting an object
    public void StopPlayer()
    {
        rigidbody.velocity = new Vector3(0, 0, 0);
        movementSpeed = 0;
        canMove = false;
        interactionBinding.Disable();

    }

    public void RestartPlayer()
    {
        movementSpeed = 5;
        canMove = true;
        interactionBinding.Enable();
    }
}


