using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivateExitDoor : MonoBehaviour
{
    
    public GameObject ExitDoor;
    private void OnTriggerEnter(Collider other)
    {

        {
            ExitDoor.SetActive(true);
            
        }
    }
}