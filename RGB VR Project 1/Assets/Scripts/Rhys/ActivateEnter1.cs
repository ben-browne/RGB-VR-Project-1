using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivateEnter1 : MonoBehaviour
{
    public GameObject EnterDoor;
    
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            EnterDoor.SetActive(true);
        }
    }
      

     



   
}
