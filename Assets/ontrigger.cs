using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ontrigger : MonoBehaviour
{
    void OnTriggerEnter(Collider other){
        Debug.Log("Touched");
    }

    void OnTriggerStay(Collider other)
    {
        Debug.Log("Inside");
    }

    void OnTriggerExit(Collider other)
    {
        Debug.Log("Gone");
    }
}
