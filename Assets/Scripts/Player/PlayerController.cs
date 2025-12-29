using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    public float Speed;
    public float RotationSpeed;
    public float MinVerticalAngle;
    public float MaxVerticalAngle;

    public InputActionAsset inputAction;
    public CharacterController characterController;
    public Camera characterCamera;
    
    // Для вращения камеры
    private float cameraPitch;
    private float cameraYaw;
    private Vector2 lookInput;
    
    // Для управления движением
    private InputAction moveAction;
    private InputAction lookAction;
    
    private void Awake()
    {
        var playerActionMap = inputAction.FindActionMap("Player");
        
        moveAction = playerActionMap.FindAction("Move");
        lookAction = playerActionMap.FindAction("Look");
    
        Cursor.lockState = CursorLockMode.Locked;
    }
    
    private void OnEnable()
    {
        moveAction.Enable();
        lookAction.Enable();
    }
    
    private void OnDisable()
    {
        moveAction.Disable();
        lookAction.Disable();
    }

    private void OnDestroy()
    {
        moveAction.Disable();
        lookAction.Disable();
     
        moveAction.Dispose();
        lookAction.Dispose();

        Cursor.lockState = CursorLockMode.Confined;
    }

    private void Update()
    {
        lookInput = lookAction.ReadValue<Vector2>();
        
        cameraYaw += lookInput.x * RotationSpeed;
        cameraPitch -= lookInput.y * RotationSpeed;
        cameraPitch = Mathf.Clamp(cameraPitch, MinVerticalAngle, MaxVerticalAngle);
        
        characterCamera.transform.localRotation = Quaternion.Euler(cameraPitch, 0f, 0f);
        transform.rotation = Quaternion.Euler(0f, cameraYaw, 0f);
    }

    private void FixedUpdate()
    {
        Vector2 moveInput = moveAction.ReadValue<Vector2>();
        Vector3 inputDirection = new Vector3(moveInput.x, 0f, moveInput.y);
        
        inputDirection = transform.TransformDirection(inputDirection);
        inputDirection *= Speed * Time.fixedDeltaTime;
        inputDirection.y = Physics.gravity.y * Time.fixedDeltaTime;
        
        characterController.Move(inputDirection);
    }
}