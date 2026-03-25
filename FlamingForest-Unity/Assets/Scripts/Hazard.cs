using JetBrains.Annotations;
using UnityEngine;

public class Hazard : MonoBehaviour
{
    public int HazardDamage = 1;   
    private void OnCollisionEnter2D(Collision2D collision)
    {
        //code to handle collision
        //Get the collider of the object we collided with
        Collider2D collider = collision.collider;

        //Try to get the player health script attached to that object
        PlayerHealth Player = collider.GetComponent<PlayerHealth>();

        //Check if we found a player health script on the collided object
        if (Player != null)
        {
            Player.ChangeHealth();
        }

        
    }
}
