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
    }

   
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.relativeVelocity.magnitude > 10)
        {
            aud.volume = collision.relativeVelocity.magnitude / 130;
            aud.Play();
        }
    } 
}
