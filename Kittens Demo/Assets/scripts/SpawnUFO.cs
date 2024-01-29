using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class SpawnUFO : MonoBehaviour
{
    UnityEvent UFO_Spawn = new UnityEvent();

    public GameObject UFO;

    UnityEvent m_MyEvent = new UnityEvent();

    void Start()
    {
        
    }

    void Update()
    {
        // Press Q to close the Listener
        if (Input.GetKey("h"))
        {
            Spawn();
        }

        //Press any other key to begin the action if the Event exists
    }

    void Spawn()
    {
        GameObject gameObject1 = Instantiate(UFO, transform.position + Vector3.up * 30f, transform.rotation);
    }
}
