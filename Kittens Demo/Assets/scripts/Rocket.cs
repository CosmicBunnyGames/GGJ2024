using UnityEngine;
using UnityEngine.Events;
public class Rocket : MonoBehaviour
{
    // Reference to the Prefab.
    public GameObject rocket;
    public float Firing_Force = 10f;
   
    void Shoot()
    {
        Debug.Log("hi");
        GameObject Projectile = Instantiate(rocket, transform.position + transform.forward * 1.7f, transform.rotation);
        Projectile.GetComponent<Rigidbody>().velocity = transform.forward * Firing_Force;
    }

}

