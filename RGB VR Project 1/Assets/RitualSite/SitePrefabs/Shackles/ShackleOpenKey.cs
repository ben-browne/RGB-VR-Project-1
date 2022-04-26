using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShackleOpenKey : MonoBehaviour
{
    public GameObject ShackleClosed;
    public GameObject ShackleOpen;
    public GameObject Key;
    public Collider KeyCollider;

    public void OnTriggerEnter(Collider KeyCollider)
    {
        ShackleClosed.SetActive(false);
        ShackleOpen.SetActive(true);
    }

}
