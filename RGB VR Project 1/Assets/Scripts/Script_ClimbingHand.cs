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

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Ledge")
        {
            grabbedLedge = collision.gameObject;
        }
    }

    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.tag == "Ledge")
        {
            grabbedLedge = null;
        }
    }
}
