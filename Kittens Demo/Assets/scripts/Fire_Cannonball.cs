using UnityEngine;
using UnityEngine.Events;
public class Fire_Cannonball : MonoBehaviour
{
    // Reference to the Prefab.
    public GameObject cannonball;
    public float Firing_Force;
    UnityEvent Fire = new UnityEvent();

    void Start()
    {
        // Instantiate at cannon position and zero rotation.

        GameObject Projectile = Instantiate(cannonball, transform.position, Quaternion.identity);
        Projectile.GetComponent<Rigidbody>().velocity = transform.forward * Firing_Force;
    }

}