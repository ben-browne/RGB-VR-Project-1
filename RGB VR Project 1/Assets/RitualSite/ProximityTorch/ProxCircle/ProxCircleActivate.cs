using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProxCircleActivate : MonoBehaviour
{

    public GameObject A1;
    public GameObject A2;
    public GameObject B1;
    public GameObject B2;
    public GameObject C1;
    public GameObject C2;
    public GameObject D1;
    public GameObject D2;
    public GameObject E1;
    public GameObject E2;
    public GameObject F1;
    public GameObject F2;
    public GameObject G1;
    public GameObject G2;
    public GameObject H1;
    public GameObject H2;

    public void OnTriggerEnter(Collider other)
    {
       
        A1.SetActive(true);
        A2.SetActive(true);
        Invoke("BLight", 0.3f);
    }

    public void BLight()
    {
        B1.SetActive(true);
        B2.SetActive(true);
        Invoke("CLight", 0.3f);
    }
    public void CLight()
    {
        C1.SetActive(true);
        C2.SetActive(true);
        Invoke("DLight", 0.3f);
    }

    public void DLight()
    {
        D1.SetActive(true);
        D2.SetActive(true);
        Invoke("ELight", 0.3f);
    }

    public void ELight()
    {
        E1.SetActive(true);
        E2.SetActive(true);
        Invoke("FLight", 0.3f);
    }

    public void FLight()
    {
        F1.SetActive(true);
        F2.SetActive(true);
        Invoke("GLight", 0.3f);
    }

    public void GLight()
    {
        G1.SetActive(true);
        G2.SetActive(true);
        Invoke("HLight", 0.3f);
    }

    public void HLight()
    {
        H1.SetActive(true);
        H2.SetActive(true);
    }
}
