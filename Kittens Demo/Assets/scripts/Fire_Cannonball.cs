using UnityEngine;
using UnityEngine.Events;
public class Fire_Cannonball : MonoBehaviour
{
    // Reference to the Prefab.
    public GameObject cannonball;
    public float Firing_Force;
    void Shoot()
    {
        GameObject Projectile = Instantiate(cannonball, transform.position + transform.up * -1.7f, Quaternion.identity);
        Projectile.GetComponent<Rigidbody>().velocity = transform.up * -1 * Firing_Force;
    }

}