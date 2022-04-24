using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class EnterDoorScript : MonoBehaviour
{

    
    private void OnTriggerEnter(Collider other)
    {
        
        {
            SceneManager.LoadScene("Inside House");
           

        }
    }



}
