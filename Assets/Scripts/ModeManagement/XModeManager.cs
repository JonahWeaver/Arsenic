using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class XModeManager : MonoBehaviour
{
    public GameObject player;

    protected PlayerInputActions inputActions;
    public CharacterController characterController;
    public float moveSpeed = 10f;
    public float smoothSpeed = 5f;
    
    public GameObject virtualCamera;

    protected Vector2 movementInput;
    protected Vector2 mouseMovementInput;
    protected bool battleTestInput;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame

    public void Activate()
    {
        if (ModeManager.Instance.currentMode != this)
        {
            ModeManager.Instance.currentMode.Deactivate();
            this.enabled = true;
        }

        player = ModeManager.Instance.GetPlayerObject();

        inputActions = new PlayerInputActions();
        inputActions.Enable();

        foreach (var actionMap in inputActions.asset.actionMaps)
        {
            actionMap.Enable();
        }
        characterController = player.GetComponent<CharacterController>();

        Init();
    }

    public void Deactivate()
    {
        this.enabled = false;
    }

    public virtual void Init()
    {
        PivotCamera();
    }

    protected virtual void PivotCamera()
    {

    }

    public void End()
    {

    }

    public void ReadInput()
    {
        movementInput = inputActions.Player.Move.ReadValue<Vector2>();
        mouseMovementInput = inputActions.CameraMovement.Look.ReadValue<Vector2>();
        battleTestInput = inputActions.Test.CreateBattleScenario.ReadValue<float>() > 0f;
    }
}
