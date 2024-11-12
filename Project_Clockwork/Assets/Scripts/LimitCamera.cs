using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LimitCamera : MonoBehaviour
{
    public GameObject Player;

    public float minX = -30f; 
    public float maxX = 30f; 
    public float minZ = -30f; 
    public float maxZ = 30f;
    private void LateUpdate()
    {
        Vector3 playerPosition = Player.transform.position;

        float clampedX = Mathf.Clamp(playerPosition.x, minX, maxX);
        float clampedZ = Mathf.Clamp(playerPosition.z, minZ, maxZ);

        transform.position = new Vector3(clampedX, 40, clampedZ);        
    }
}
