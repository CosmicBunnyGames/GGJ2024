using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;
using UnityEngine.Events;

public class SpawnAnvil : MonoBehaviour
{


    public GameObject anvil;

    UnityEvent m_MyEvent = new UnityEvent();

    void Start()
    {
        m_MyEvent.AddListener(MyAction);
    }

    void Update()
    {
        if (Input.GetKeyDown("f"))
        {
            m_MyEvent.Invoke();
            m_MyEvent.RemoveListener(MyAction);
        }
    }

     void MyAction()
    {
        GameObject gameObject1 = Instantiate(anvil, transform.position + Vector3.forward*10f + Vector3.up*20f, quaternion.identity);
    }
}
