using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PoliceLights : MonoBehaviour
{
    public GameObject Blue;
    public GameObject Red;

    public void Start()
    {
        BlueOn();
    }

    public void BlueOn()
    {
        Blue.SetActive(true);
        Red.SetActive(false);
        Invoke("RedOn", 0.5f);
    }

    public void RedOn()
    {
        Blue.SetActive(false);
        Red.SetActive(true);
        Invoke("BlueOn", 0.5f);
    }
}
