using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileBehavior : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag != "Player")  //destroy projectile if it collides with anything but the player
        {
            // make the projectile disappear
            Destroy(gameObject);
        }
    }
}
