using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class keytele : MonoBehaviour
{
    public GameObject Key;
    public Collider KeyCollider;

    public void OnTriggerEnter(Collider KeyCollider)
    {
        if (KeyCollider.gameObject.tag == "Key")
        {
            GameObject.Find("XR Origin").transform.position = new Vector3(-75.9f, 0.8f, 314.7f);
        }
    }
}
