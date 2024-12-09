using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Steam_SFX : MonoBehaviour
{
    public AudioClip steamExpl;
    public float life = 1f;

    private AudioSource steamGren;

    // Start is called before the first frame update
    void Start()
    {
        steamGren = GetComponent<AudioSource>();
        steamGren.PlayOneShot(steamExpl, 1.0f);
        Destroy(gameObject, life);
    }

    
    void Update()
    {
        
    }
}
