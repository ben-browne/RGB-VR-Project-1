using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Script_Ledge : MonoBehaviour
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
        if (other.gameObject.tag == "Hand")
        {
            print("in range of ledge");
            GameObject.Find("Interact Manager").GetComponent<Script_Interact>().ObjectToInteractWith = gameObject;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Hand")
        {
            print("out of range of ledge");
            GameObject.Find("Interact Manager").GetComponent<Script_Interact>().ObjectToInteractWith = null;
        }
    }
}
