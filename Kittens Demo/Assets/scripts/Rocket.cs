using UnityEngine;
using UnityEngine.Events;
public class Rocket : MonoBehaviour
{
    // Reference to the Prefab.
    public GameObject rocket;
    public float Firing_Force = 10f;
    private UnityEvent cannonShoot = new UnityEvent();

    void Start()
    {
        //Add a listener to the new Event. Calls MyAction method when invoked
        cannonShoot.AddListener(MyAction);
    }
    void Update()
    {
        // Instantiate at cannon position and zero rotation.
        if (Input.GetKeyDown("f"))
        {
            cannonShoot.Invoke();
        }


    }
    void MyAction()
    {
        Debug.Log("hi");
        GameObject Projectile = Instantiate(rocket, transform.position + transform.forward * 1.7f, transform.rotation);
        Projectile.GetComponent<Rigidbody>().velocity = transform.forward * Firing_Force;
    }

}

