using UnityEngine;
using UnityEngine.Events;
public class Fire_Cannonball : MonoBehaviour

{
    private bool notShot = true;
    // Reference to the Prefab.
    public GameObject cannonball;
    void Update()
    {
        if (notShot)
        {
            GameObject Projectile = Instantiate(cannonball, transform.position + transform.up * -1.7f, Quaternion.identity);
            Projectile.GetComponent<Rigidbody>().velocity = transform.up * -1 * 100f;
            notShot = false;
        }
    }

}