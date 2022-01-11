using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FiringBehavior : MonoBehaviour
{

   public Transform spawn_coor;        //where the projectile will spawn
   public float projectile_speed;          //how fast projectile will go

   public GameObject projectile_object;    //red projectile sprite

   // Start is called before the first frame update
   void Start()
   {
       projectile_speed = 15f;
   }      

   // Update is called once per frame
   void Update()
   {
       if(Input.GetButtonDown("Jump")) //space bar will spawn projectile
       {
           GameObject projectile = Instantiate(projectile_object, spawn_coor.position, spawn_coor.rotation);
           Rigidbody2D rb = projectile.GetComponent<Rigidbody2D>();
           rb.AddForce(spawn_coor.up * projectile_speed, ForceMode2D.Impulse); //makes projectile move
       }
   }
}