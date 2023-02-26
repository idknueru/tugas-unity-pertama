using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class huh : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //transform.Translate(Vector3.right * 5 * Time.deltaTime);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.left * 5 * Time.deltaTime);
    }
}
