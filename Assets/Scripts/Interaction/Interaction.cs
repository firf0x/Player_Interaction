using UnityEngine;
using UnityEngine.InputSystem;

public class Interaction : MonoBehaviour
{
    [SerializeField] private float rayDistance;
    [SerializeField] private InputActionAsset inputAction;
    private InputAction interactAction;

    private void Awake()
    {
        var playerActionMap = inputAction.FindActionMap("Player");
        
        interactAction = playerActionMap.FindAction("Interact");
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
        if(Physics.Raycast(gameObject.transform.position, gameObject.transform.forward, out var hitInfo, rayDistance ))
        {
            if( interactAction.triggered && hitInfo.collider.gameObject.GetComponent<InteractableComponent>() != null )
            {
                hitInfo.collider.gameObject.GetComponent<InteractableComponent>().OnInteract();
            }
        }
    } 
}