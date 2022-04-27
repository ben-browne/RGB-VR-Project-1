using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Script_Interact : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject ObjectToInteractWith;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        print(ObjectToInteractWith.name);
    }

    public void interact()
    {
        print("interact function succesfully triggered");

        if (ObjectToInteractWith.tag == "Door")
        {
            print("door successfully detected");
            ObjectToInteractWith.GetComponent<Script_Door>().testFunction();
        }
        else if (ObjectToInteractWith.tag == "Table")
        {
            print("table successfully detected");
            ObjectToInteractWith.GetComponent<GirlPickup>().PickupGirl();
        }
        else if (ObjectToInteractWith.tag == "Ledge")
        {
            print("ledge successfully detected");
            ObjectToInteractWith.GetComponent<Script_ClimbingMaster>().climb();
        }
    }
}
