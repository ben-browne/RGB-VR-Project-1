using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShackleHammer : MonoBehaviour
{
    public GameObject ShackleClosed;
    public GameObject ShackleOpen;
    public GameObject Lock;
    public GameObject pickupbox;
    public Collider LockCollider;
    public float speed;
    public Vector3 oldPosition;


    public void Update()
    {
        speed = Vector3.Distance(oldPosition, transform.position);
        oldPosition = transform.position;
        Debug.Log(speed);
    }

    public void OnTriggerEnter(Collider LockCollider)
    {
        if(speed > 1)
        {
        ShackleClosed.SetActive(false);
        ShackleOpen.SetActive(true);
            Pickup();
        }
    }

    public void Pickup()
    {
        pickupbox.SetActive(true);
    }
}
