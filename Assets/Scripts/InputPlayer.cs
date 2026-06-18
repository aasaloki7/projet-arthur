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

    private void Update()
    {
        Move();
    }

    private void Move()
    {
        moveVector2 = moveInputActionReference.action.ReadValue<Vector2>();
        player.Move(moveVector2);
    }


    void Jump(InputAction.CallbackContext callbackContext)

    private void Update()
    {
        Jump();
    }

    private void Jump()
    {
        throw new NotImplementedException();
    }

    private void OnEnable()
    {
        jumpInputActionReference.action.Enable();
        jumpInputActionReference.action.performed += Jump;
    }

    private void OnDisable()
    {
        jumpInputActionReference.action.Disable();
        jumpInputActionReference.action.performed -= Jump;
    }
}













//private void OnEnable() {
        //moveInputActionReference.action.Enable();
        // moveInputActionReference.action.performed += Move;
    //}

    //private void OnDisable()
    //{
        //moveInputActionReference.action.Disable();
        // moveInputActionReference.action.performed -= Move;
    //}
//}
