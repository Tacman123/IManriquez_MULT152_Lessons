using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstaclePush : MonoBehaviour
{
    private float pushPower = 5f;
    private void OnControllerColliderHit(ControllerColliderHit hit)
    {
        if (hit.transform.tag == "Movable")
        {
            Rigidbody box = hit.collider.GetComponent<Rigidbody>();

            if(box != null)
            {
                Vector3 pushDirection = new Vector3(hit.moveDirection.x, 0, 0);
                box.velocity = pushDirection * pushPower;
            }
        }
    }

}
