using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartButton : MonoBehaviour
{
    
   public GameObject pop_up_box;
 
 
   public void popDown()
   {
       pop_up_box.SetActive(false);
   }
}
