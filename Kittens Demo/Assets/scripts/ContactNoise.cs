using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ContactNoise : MonoBehaviour
{
    AudioSource aud;
    // Start is called before the first frame update
    void Start()
    {
        aud= GetComponent<AudioSource>();
        aud.pitch = 10f;
    }

   
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.relativeVelocity.magnitude > 3)
        {
            aud.volume = collision.relativeVelocity.magnitude / 50;
            aud.Play();
        }
    } 
}
