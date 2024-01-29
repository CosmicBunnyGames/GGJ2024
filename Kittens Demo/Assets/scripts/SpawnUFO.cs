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
        //Add a listener to the new Event. Calls MyAction method when invoked
        m_MyEvent.AddListener(MyAction);
    }

    void Update()
    {
        // Press Q to close the Listener
        if (Input.GetKeyDown("u"))
        {
            m_MyEvent.Invoke();
        }

        //Press any other key to begin the action if the Event exists
    }




    // Update is called once per frame

    void MyAction()
    {
        GameObject gameObject1 = Instantiate(UFO, transform.position + Vector3.up * 30f, transform.rotation);
    }
}
