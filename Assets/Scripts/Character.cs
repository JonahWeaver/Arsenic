using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Character : MonoBehaviour
{
    private PlayerInputActions inputActions;
    private CharacterController characterController;
    public float moveSpeed = 10f;
    public float smoothSpeed = 5f;
    public GameObject virtualCamera;
    private Vector2 movementInput;

    
    // 
    // Start is called before the first frame update
    void Awake()
    {
        //inputActions = new PlayerInputActions();
        //inputActions.Player.Move.performed += OnMovePerformed;
        //inputActions.Player.Move.canceled += OnMoveCanceled;
        //characterController = GetComponent<CharacterController>();
    }

    private void OnEnable()
    {
        //Debug.Log(inputActions);
       // inputActions.Player.Enable();
    }

    private void OnDisable()
    {
       // inputActions.Player.Disable();
    }

    // Update is called once per frame
    void LateUpdate()
    {
        //Vector3 forwardDir = virtualCamera.transform.forward;
        //forwardDir.y = 0;
        //forwardDir.Normalize();
        //Vector3 rightDir = Vector3.Cross(Vector3.up, forwardDir);

        // Get input axes
        //float horizontalInput = Input.GetAxis("Horizontal"); // Left/Right
        //float verticalInput = Input.GetAxis("Vertical");     // Forward/Backward

        // Calculate movement vector
        //Vector3 moveDirection = (rightDir * movementInput.x) + (forwardDir * movementInput.y);
        //characterController.Move(moveDirection * moveSpeed * Time.deltaTime);
        //if (moveDirection != Vector3.zero)
        //{
        //    // Apply movement
        //    Quaternion targetRotation = Quaternion.LookRotation(moveDirection);
        //    Quaternion yRotation = Quaternion.Euler(0, targetRotation.eulerAngles.y, 0);
//
        //    transform.rotation = Quaternion.Slerp(transform.rotation, yRotation, Time.deltaTime * smoothSpeed);
        //}
    }

    private void OnMovePerformed(InputAction.CallbackContext context)
    {
        movementInput = context.ReadValue<Vector2>();
    }

    private void OnMoveCanceled(InputAction.CallbackContext context)
    {
        movementInput = Vector2.zero;
    }
}
