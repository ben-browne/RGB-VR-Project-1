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
    public GameObject EndZone;


    public void PickupGirl()
    {

                Tablegirl.SetActive(false);
                Shouldergirl.SetActive(true);
                Ghoul.SetActive(true);
        EndZone.SetActive(true);
 
    }
}
