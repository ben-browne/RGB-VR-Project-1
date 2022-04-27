using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Script_ClimbingMaster : MonoBehaviour
{

    GameObject Hand_L;
    GameObject Hand_R;

    // Start is called before the first frame update
    void Start()
    {
        Hand_L = GameObject.Find("Hand_L");
        Hand_R = GameObject.Find("Hand_R");
    }

    // Update is called once per frame
    void Update()
    {
        /*

        if (Input.GetAxis("Axis 11") > 0)
        {
            print("Left");
            if (Hand_L.GetComponent<Script_ClimbingHand>().grabbedLedge != null)
            {
                //GameObject.Find("XR Origin").transform.position = Hand_L.GetComponent<Script_ClimbingHand>().grabbedLedge.transform.position;
            }
        }
        if (Input.GetAxis("Axis 12") > 0)
        {
            print("Right");
            if (Hand_R.GetComponent<Script_ClimbingHand>().grabbedLedge != null)
            {
                //GameObject.Find("XR Origin").transform.position = Hand_R.GetComponent<Script_ClimbingHand>().grabbedLedge.transform.position;
            }
        } */
    }

    public void climb()
    {
        print("climb");
    }
}
