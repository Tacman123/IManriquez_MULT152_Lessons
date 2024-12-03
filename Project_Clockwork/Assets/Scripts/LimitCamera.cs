using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LimitCamera : MonoBehaviour
{
    public GameObject player;
    public GameObject scoutBot;

    private float minX = -30f; 
    private float maxX = 30f; 
    private float minZ = -30f; 
    private float maxZ = 30f;
    private GameObject currentTarget;

    // Start is called before the first frame update
    void Start()
    {
        currentTarget = player;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SetTarget(GameObject newTarget)
    {
        currentTarget = newTarget;
    }



    private void LateUpdate()
    {
        Vector3 playerPosition = player.transform.position;

        float clampedX = Mathf.Clamp(playerPosition.x, minX, maxX);
        float clampedZ = Mathf.Clamp(playerPosition.z, minZ, maxZ);

        transform.position = new Vector3(clampedX, 40, clampedZ);        
    }
}
