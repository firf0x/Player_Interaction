using UnityEngine;
using UnityEngine.InputSystem;

public class Interaction : MonoBehaviour
{
    [SerializeField] private float rayDistance;
    [SerializeField] private InputActionAsset inputAction;
    
    private InputAction interactAction;
    private Camera playerCamera;
    private InteractableComponent currentHoveredObject;

    private void Awake()
    {
        var playerActionMap = inputAction.FindActionMap("Player");
        
        interactAction = playerActionMap.FindAction("Interact");
        playerCamera = Camera.main;
    }

    private void OnEnable()
    {
        interactAction.Enable();
    }

    void OnDisable()
    {
        interactAction.Disable();
    }

    private void Update()
    {
        InteractableComponent newHoveredObject = null;
        
        if (Physics.Raycast(playerCamera.transform.position, playerCamera.transform.forward, out var hitInfo, rayDistance))
        {
            newHoveredObject = hitInfo.collider.gameObject.GetComponent<InteractableComponent>();
        }
        
        if (newHoveredObject != currentHoveredObject)
        {
            if (currentHoveredObject != null)
            {
                currentHoveredObject.OnHoverExit();
            }
            
            currentHoveredObject = newHoveredObject;
            if (currentHoveredObject != null)
            {
                currentHoveredObject.OnHoverEnter();
            }
        }
        
        if (interactAction.triggered && currentHoveredObject != null)
        {
            currentHoveredObject.OnInteract();
        }
    }
}