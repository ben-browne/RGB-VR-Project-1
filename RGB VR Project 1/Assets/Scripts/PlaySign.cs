using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaySign : MonoBehaviour
{
    public GameObject PostRise;
    private void OnTriggerEnter(Collider other)
    {

        {
            PostRise.SetActive(true);
        }
    }
}
