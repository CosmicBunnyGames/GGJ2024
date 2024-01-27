using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Joint_On_Contact : MonoBehaviour
{

    private int temp = 0;
    // Start is called before the first frame update
    void Start()
    {
        Vector3 explosionPos = transform.position;
        Collider[] colliders = Physics.OverlapSphere(explosionPos, 2.0f);
        foreach (Collider hit in colliders)
        {
            Rigidbody rb = hit.GetComponent<Rigidbody>();
            if (rb != null)
                gameObject.AddComponent<FixedJoint>();
        }
        List<FixedJoint> FixedJoints = new List<FixedJoint>();
        gameObject.GetComponents(FixedJoints);
        foreach (Collider hit in colliders){
            Rigidbody rb = hit.GetComponent<Rigidbody>();
            if (rb != null)
                FixedJoints[temp].connectedBody=rb;
                temp = temp+1;
        }
        foreach (FixedJoint joint in FixedJoints)
        {
            joint.breakForce = 100f;
            joint.breakTorque = 300f;
            if(joint.connectedBody==null){
                joint.breakForce = 0.01f;
                joint.breakTorque = 0.01f;
            }
        }
            
    }



}
