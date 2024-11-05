using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Steam_SFX : MonoBehaviour
{
    public AudioClip steamExpl;

    private AudioSource steamGren;

    // Start is called before the first frame update
    void Start()
    {
        steamGren = GetComponent<AudioSource>();
        steamGren.PlayOneShot(steamExpl, 1.0f);
    }

    
    void Update()
    {
        
    }
}
