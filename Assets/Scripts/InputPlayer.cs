using System;
using UnityEngine;
using UnityEngine.InputSystem;

public class InputPlayer : MonoBehaviour
{
    [SerializeField] private Player player;

    [SerializeField] private InputActionReference moveInputActionReference;
    [SerializeField] private InputActionReference jumpInputActionReference;
    [SerializeField] private InputActionReference shootInputActionReference;
    [SerializeField] private InputActionReference dashInputActionReference;

    public Vector2 moveVector2 = new Vector2();

    // Update
    
    private void Update()
    {
        if (moveInputActionReference.action.ReadValue<Vector2>().magnitude > 0)
            Move();
    }

    // Move
    
    private void Move()
    {
        moveVector2 = moveInputActionReference.action.ReadValue<Vector2>();
        player.Move(moveVector2);
    }

    
    
    // Jump

    private void Jump(InputAction.CallbackContext callbackContext)
    {
        player.Jump(callbackContext.ReadValueAsButton());
    }
    

    private void OnEnable()
    {
        moveInputActionReference.action.Enable();
        jumpInputActionReference.action.Enable();
        jumpInputActionReference.action.performed += Jump;
    }

    private void OnDisable()
    {
        moveInputActionReference.action.Disable();
        jumpInputActionReference.action.Disable();
        jumpInputActionReference.action.performed -= Jump;
    }
}


// Attacks



