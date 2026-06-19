using UnityEngine;

public class Player : MonoBehaviour {
    [SerializeField] private Rigidbody rigidbodyPlayer;
    
    [SerializeField] private float moveForce;
    [SerializeField] private float jumpForce;
    
    public void Move(Vector2 moveVector2)
    {
        rigidbodyPlayer.AddForce(moveVector2.x * moveForce, 0, 0);
    }

    public void Jump(bool isJumping)
    {
        if (isJumping)
            rigidbodyPlayer.AddForce(0, jumpForce, 0);
    }
}

