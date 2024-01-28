using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class SpawnUFO : MonoBehaviour
{
    UnityEvent UFO_Spawn = new UnityEvent();

    public GameObject UFO;
    void Start()
    {
        
        UFO_Spawn.AddListener(MyAction);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("f") && UFO_Spawn != null)
        {
            //Begin the action
            UFO_Spawn.Invoke();
        }
    }
     void MyAction()
    {
        Debug.Log("Do Stuff");
        GameObject gameObject1 = Instantiate(UFO, transform.position + Vector3.up * 30f, transform.rotation);
    }
}
