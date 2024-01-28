using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveForwards : MonoBehaviour
{
    Rigidbody m_Rigidbody;
    public float m_Speed = 5f;

    void Start()
    {
        m_Rigidbody = GetComponent<Rigidbody>();
    }


        void FixedUpdate()
    {
        Vector3 m_Input = transform.forward;

        m_Rigidbody.MovePosition(transform.position + m_Input * Time.deltaTime * m_Speed);
    }
    
}
