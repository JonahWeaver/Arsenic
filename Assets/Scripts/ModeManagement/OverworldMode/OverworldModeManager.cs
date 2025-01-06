using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class OverworldModeManager : XModeManager
{
    public Vector2 sensitivity = new Vector2(50f, 50f);
    public GameObject lookObject;
    
    private float currentYaw;
    private float currentPitch;

    public Vector2 verticalRotationLimits = new Vector2(-60f, 60f);

    // Update is called once per frame
    void Update()
    {
        ReadInput();

        if(battleTestInput)
        {
            BattleModeManager battleManager = gameObject.GetComponent<BattleModeManager>();
            battleManager.Activate();
            return;
        }

        Vector3 forwardDir = lookObject.transform.forward;
        forwardDir.y = 0;
        forwardDir.Normalize();
        Vector3 rightDir = Vector3.Cross(Vector3.up, forwardDir);

        // Get input axes
        float horizontalInput = Input.GetAxis("Horizontal"); // Left/Right
        float verticalInput = Input.GetAxis("Vertical");     // Forward/Backward

        // Calculate movement vector
        Vector3 moveDirection = (rightDir * movementInput.x) + (forwardDir * movementInput.y);
        characterController.Move(moveDirection * moveSpeed * Time.deltaTime);
        if (moveDirection != Vector3.zero)
        {
            // Apply movement
            Quaternion targetRotation = Quaternion.LookRotation(moveDirection);
            Quaternion yRotation = Quaternion.Euler(0, targetRotation.eulerAngles.y, 0);

            player.transform.rotation = Quaternion.Slerp(player.transform.rotation, yRotation, Time.deltaTime * smoothSpeed);
        }

        currentYaw += mouseMovementInput.x * sensitivity.x * Time.deltaTime;
        currentPitch -= mouseMovementInput.y * sensitivity.y * Time.deltaTime;

        // Clamp the pitch to avoid flipping the camera
        currentPitch = Mathf.Clamp(currentPitch, verticalRotationLimits.x, verticalRotationLimits.y);

        // Apply rotation
        lookObject.transform.rotation = Quaternion.Euler(currentPitch, currentYaw, 0f);
    }
}
