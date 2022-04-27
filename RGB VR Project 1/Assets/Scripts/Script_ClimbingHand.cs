using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Script_ClimbingHand : MonoBehaviour
{

    public GameObject grabbedLedge;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Ledge")
        {
            grabbedLedge = other.gameObject;
            print("in range of ledge");
            GameObject.Find("Interact Manager").GetComponent<Script_Interact>().ObjectToInteractWith = gameObject;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Ledge")
        {
            grabbedLedge = null;
            print("out of range of door");
            GameObject.Find("Interact Manager").GetComponent<Script_Interact>().ObjectToInteractWith = null;
        }
    }
}
