using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyedWall : MonoBehaviour
{
    public float life = 3;

    // Start is called before the first frame update
    void Start()
    {
        Destroy(gameObject, life);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
