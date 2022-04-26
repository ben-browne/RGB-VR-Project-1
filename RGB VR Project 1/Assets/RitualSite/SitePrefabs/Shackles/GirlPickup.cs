using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GirlPickup : MonoBehaviour
{
    public GameObject Tablegirl;
    public GameObject Shouldergirl;
    public GameObject Ghoul;
    public Collider pickupbox;
    public bool Inbox = true;

    public void OnTriggerEnter(Collider other)
    {
        Inbox = !Inbox;
    }

    public void OnTriggerExit(Collider other)
    {
        Inbox = !Inbox;
    }

    public void Update()
    {
        if(Inbox == true)
        {
            if (Input.GetKey(KeyCode.E)) // change  input
            {
                Tablegirl.SetActive(false);
                Shouldergirl.SetActive(true);
                Ghoul.SetActive(true);
            }
        }
    }
}
