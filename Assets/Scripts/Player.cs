using UnityEngine;

public class Player : MonoBehaviour {
    [SerializeField] private Rigidbody rigidbodyPlayer;
    [SerializeField] private float moveForce;

    public void Move(Vector2 moveVector2)
    {
        rigidbodyPlayer.AddForce(moveVector2.x * moveForce, 0, 0);
    }

    public void Jump(Vector2 jumpVector2)
    {
        rigidbodyPlayer.AddForce(jumpVector2.x = 0, y * moveForce, 0);
    }
}
