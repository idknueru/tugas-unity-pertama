using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class oncollide : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }
    void OnCollisionEnter(Collision collision)
    {
        Debug.Log("Entered");
    }

    void OnCollisionExit(Collision collision)
    {
        Debug.Log("Exited"); 
    }

    void OnCollisionStay(Collision collision){
        Debug.Log("Currently staying...");
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
