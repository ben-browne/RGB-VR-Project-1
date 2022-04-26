using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProxTorchActivate : MonoBehaviour
{

    public GameObject Fire1;
    public GameObject Fire2;

    public void OnTriggerEnter(Collider other)
    {
            Fire1.SetActive(true);
            Fire2.SetActive(true);
    }
}
