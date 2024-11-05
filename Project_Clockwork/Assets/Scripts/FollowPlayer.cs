using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public GameObject player;
    

    private Vector3 offset = new Vector3(0, 6.5f, -6f);
    private GameObject currentTarget;

    // Start is called before the first frame update
    void Start()
    {
        currentTarget = player;
    }

    // Update is called once per frame
    void Update()
    {
        if (currentTarget != null)
        {
            transform.position = currentTarget.transform.position + offset;
        }                
    }

    public void SetTarget(GameObject newTarget)
    {
        currentTarget = newTarget;
    }
}