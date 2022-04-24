using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PressEscript : MonoBehaviour
{
    public GameObject PressRT;

    private void OnTriggerEnter(Collider other)
    {

        {
            PressRT.SetActive(true);

        }
    }
}
