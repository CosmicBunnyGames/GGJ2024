using UnityEngine;
using UnityEngine.Events;
public class Fire_Cannonball : MonoBehaviour
{
    // Reference to the Prefab.
    public GameObject cannonball;
    public float Firing_Force;
    private UnityEvent cannonShoot = new UnityEvent();

    void Start()
    {
        //Add a listener to the new Event. Calls MyAction method when invoked
        cannonShoot.AddListener(MyAction);
    }
    void Update()
    {
        // Instantiate at cannon position and zero rotation.
        if (Input.GetKeyDown("g"))
        {
            cannonShoot.Invoke();
            cannonShoot.RemoveListener(MyAction);
        }


    }
    void MyAction()
    {
        Debug.Log("hi");
        GameObject Projectile = Instantiate(cannonball, transform.position + transform.up * -1.7f, Quaternion.identity);
        Projectile.GetComponent<Rigidbody>().velocity = transform.up * -1 * Firing_Force;
    }

}