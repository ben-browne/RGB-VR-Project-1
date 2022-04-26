using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;
using UnityEngine.SceneManagement;

public class OpenDoorTrigger : MonoBehaviour
{
    public bool IsInRangeOfDoor = false;

    public InputDevice RightController;
    void Start()
    {
        List<InputDevice> devices = new List<InputDevice>();

        InputDeviceCharacteristics rightControllerCharacteristics = InputDeviceCharacteristics.Right | InputDeviceCharacteristics.Controller;

        InputDevices.GetDevicesWithCharacteristics(rightControllerCharacteristics, devices);

        foreach (var item in devices)
        {

        }

    }

    void Update()
    {
        if (IsInRangeOfDoor)
        {
            RightController.TryGetFeatureValue(CommonUsages.trigger, out float triggerValue);
            if (triggerValue > 0.5f)
            {
                print("pressed trigger");
                GameObject.Find("XR Origin").transform.position = new Vector3(-75.8f, -10.3f, 314.8f);
            }
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "XR Origin")
        {
            print("is in range");
            IsInRangeOfDoor = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.name == "XR Origin")
        {
            print("out of range");
            IsInRangeOfDoor = false;
        }
    }

}
