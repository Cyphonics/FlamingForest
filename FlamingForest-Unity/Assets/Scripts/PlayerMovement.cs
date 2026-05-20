using UnityEngine;

// This means that our script can only be placed on an object that has a Rigidbody2D
[RequireComponent (typeof(Rigidbody2D))]
public class PlayerMovement : MonoBehaviour
{
    // Script Variables
    public float speed = 1f;

    private Rigidbody2D physicsBody = null;

    private void Awake()
    {
        // Gets the Rigidbody2D component that is attached to the same object as this script and stores that component in the physicsBody variable
        physicsBody = GetComponent<Rigidbody2D>();

    }

    public void MoveLeft()
    {
        // go to the Rigidbody2D stored in our variable and change the linear velocty's X value to -1 (left)
        physicsBody.linearVelocityX = -speed;
    }

    public void MoveRight()
    {
        // go to the Rigidbody2D stored in our variable and change the linear velocty's X value to -1 (left)
        physicsBody.linearVelocityX = speed;
    }
    public void MoveUp()
    {
        // go to the Rigidbody2D stored in our variable and change the linear velocty's X value to -1 (left)
        physicsBody.linearVelocityY = speed;
    }
    public void MoveDown()
    {
        // go to the Rigidbody2D stored in our variable and change the linear velocty's X value to -1 (left)
        physicsBody.linearVelocityY = -speed;
    }

}
