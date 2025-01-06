using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class RotateFollowTarget : MonoBehaviour
{
    public Vector2 sensitivity = new Vector2(50f, 50f);
    private Vector2 lookInput;
    private float currentYaw;
    private float currentPitch;
    private PlayerInputActions inputActions;

    public Vector2 verticalRotationLimits = new Vector2(-60f, 60f);

    private void Awake()
    {
        inputActions = new PlayerInputActions();
        inputActions.CameraMovement.Look.performed += OnLookPerformed;
        inputActions.CameraMovement.Look.canceled += OnLookCanceled;
    }

    private void OnEnable()
    {
        inputActions.CameraMovement.Enable();
    }

    private void OnDisable()
    {
        inputActions.CameraMovement.Disable();
    }

    private void LateUpdate()
    {
        // Update yaw and pitch based on input
        currentYaw += lookInput.x * sensitivity.x * Time.deltaTime;
        currentPitch -= lookInput.y * sensitivity.y * Time.deltaTime;

        // Clamp the pitch to avoid flipping the camera
        currentPitch = Mathf.Clamp(currentPitch, verticalRotationLimits.x, verticalRotationLimits.y);

        // Apply rotation
        transform.rotation = Quaternion.Euler(currentPitch, currentYaw, 0f);
    }

    private void OnLookPerformed(InputAction.CallbackContext context)
    {
        lookInput = context.ReadValue<Vector2>();
    }

    private void OnLookCanceled(InputAction.CallbackContext context)
    {
        lookInput = Vector2.zero;
    }
}
