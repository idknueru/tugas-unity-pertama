using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jump : MonoBehaviour
{
    public float jumpforce = 5f;
    private Rigidbody rb;

public LayerMask groundLayer;
public float raycastDistance = 0.6f;
private bool isGrounded;

    /*private bool RaycastHit hit;
    if (Physics.Raycast(transform.position, Vector3.down, out hit, raycastDistance, groundLayer))
        isGrounded = true;
            else
        isGrounded = false;*/


    function update()
    {
        var ray : Ray = camera.ScreenPointToRay(Input.mousePosition); 

        Debug.DrawRay(ray.origin, ray.direction * 10, Color.yellow);

        var a : RaycastHit;

        if(Physics.Raycast(ray, a))
        {
            if(a.rigidbody && Input.GetMouseButton(0))
            {
                a.rigidbody.AddForce(Vector3.up * jumpforce, ForceMode.Impulse);
            }
        }
    }
/*private void OnMouseDown()
{
    if(Input.GetKey("mouse 0"))
    {
            Debug.Log("mouse is down");
        Rigidbody.AddForce(Vector3.up * jumpforce, ForceMode.Impulse);
    }
}*/

}
