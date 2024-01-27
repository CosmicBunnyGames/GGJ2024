
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Explosive : MonoBehaviour
{
    public float Impact_Limit;
    public float Power;
    public float Radius;
    public float projection;
    void OnCollisionEnter(Collision collision)
    {
        if (collision.relativeVelocity.magnitude > Impact_Limit)
        {
            Vector3 explosionPos = transform.position;
            Collider[] colliders = Physics.OverlapSphere(explosionPos, Radius);
            foreach (Collider hit in colliders)
            {
                Rigidbody rb = hit.GetComponent<Rigidbody>();
                if (rb != null)
                    rb.AddExplosionForce(Power, explosionPos, Radius, projection);
            }

            Destroy(gameObject);
        }
    }
}
