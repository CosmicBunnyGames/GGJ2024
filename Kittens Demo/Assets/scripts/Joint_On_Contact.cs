using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Joint_On_Contact : MonoBehaviour
{

    private int temp = 0;
    public float breakforce;
    public float breaktorque;
    public float jointradius;

    // Start is called before the first frame update
    void Start()
    {
        Vector3 explosionPos = transform.position;
        Collider[] colliders = Physics.OverlapSphere(explosionPos, jointradius);
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
            joint.breakForce = breakforce;
            joint.breakTorque = breaktorque;
            if(joint.connectedBody==null){
                joint.breakForce = 0.01f;
                joint.breakTorque = 0.01f;
            }
        }
            
    }



}
