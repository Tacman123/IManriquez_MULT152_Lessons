using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Explosion_Sound : MonoBehaviour
{
    public AudioSource source;
    public AudioClip clip;
    Steam_Explosion se;

    // Start is called before the first frame update
    void Start()
    {
        se = FindObjectOfType<Steam_Explosion>();
    }

    // Update is called once per frame
    void Update()
    {
        if (se.hasExploded != false)
        {
            source.PlayOneShot(clip);
        }
    }
}
