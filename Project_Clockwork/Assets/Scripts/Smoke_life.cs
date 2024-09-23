using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Smoke_life : MonoBehaviour
{
    public float life = 1.5f;

    // Start is called before the first frame update
    void Awake()
    {
        Destroy(gameObject, life);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
