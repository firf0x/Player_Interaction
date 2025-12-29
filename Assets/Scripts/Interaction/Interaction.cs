using UnityEngine;
using UnityEngine.InputSystem;

public class Interaction : MonoBehaviour
{
    [SerializeField] private float rayDistance;
    [SerializeField] private InputAction interactAction;
    
    private void Update()
    {
        if(Physics.Raycast(gameObject.transform.position, gameObject.transform.forward, out var hitInfo, rayDistance ))
        {
            if(interactAction.ReadValue<bool>() && hitInfo.collider.gameObject.GetComponent<InteractableComponent>() != null)
                hitInfo.collider.gameObject.GetComponent<InteractableComponent>();
        }
    } 
}