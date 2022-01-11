using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBehavior : MonoBehaviour
{

    GameObject cam;
    private Outline outline;

    void Start()
    {
        cam = GameObject.Find("Main Camera");
        outline = cam.GetComponent<Outline>();
    }
    
    void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Projectile") //destroy enemy if it collides with a projectile
        {
            // make the enemy disappear
            Destroy(gameObject);
            outline.enemies_left--;
        }
    }
}
