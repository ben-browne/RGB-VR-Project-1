using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Script_Door : MonoBehaviour
{
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
        if (other.gameObject.name == "XR Origin")
        {
            print("in range of door");
            GameObject.Find("Interact Manager").GetComponent<Script_Interact>().ObjectToInteractWith = gameObject;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.name == "XR Origin")
        {
            print("out of range of door");
            GameObject.Find("Interact Manager").GetComponent<Script_Interact>().ObjectToInteractWith = null;
        }
    }


    public void testFunction()
    {
        print("--- TRIGGER SUCCESSFUL ---");
        GameObject.Find("XR Origin").transform.position = new Vector3(-75.8f, -10.3f, 314.8f);
    }

}
