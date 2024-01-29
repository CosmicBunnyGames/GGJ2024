using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Script : MonoBehaviour
{
    Vector3 Angles;
    public float sensitivityX;
    public float sensitivityY;
    public float Firing_Force;
    public GameObject pivot;
    public GameObject rocket;
    public GameObject cannon;
    public GameObject anvil;
    public GameObject ufo;
    public GameObject[] weapons;
    void Start()
    {

    }
    void Update()
    {
        if (Cursor.lockState == CursorLockMode.None)
        {
            if (Input.GetMouseButton(0))
            {
                Cursor.lockState = CursorLockMode.Locked;
            }
        }
        else
        {
            if (Input.GetKey("escape")){
                Debug.Log("Exit");
                SceneManager.LoadScene("main_menu");
            }
            float rotationY = Input.GetAxis("Mouse Y") * sensitivityX;
            float rotationX = Input.GetAxis("Mouse X") * sensitivityY;

            if (rotationY > 0)
                Angles = new Vector3(Mathf.MoveTowards(Angles.x, -80, rotationY), Angles.y + rotationX, 0);
            else
                Angles = new Vector3(Mathf.MoveTowards(Angles.x, 80, -rotationY), Angles.y + rotationX, 0);
            transform.localEulerAngles = new Vector3(0, Angles.y, 0);
            pivot.transform.localEulerAngles = new Vector3(Angles.x, 0, 0);

            if (Input.GetMouseButtonDown(0))
            {
                int rngWeap = Random.Range(0, 3);
                switch (rngWeap)
                {
                    case 0:
                        GameObject Cannon = Instantiate(cannon, transform.position + transform.forward * 3f, transform.rotation);
                        break;
                    //case 1:
                    //    GameObject Rocket = Instantiate(rocket, transform.position + transform.forward * 3f, transform.rotation);
                    //    Rocket.GetComponent<Rigidbody>().velocity = transform.forward * Firing_Force;
                    //    break;
                    case 1:
                        GameObject Anvil = Instantiate(anvil, transform.position + transform.forward*10f + transform.up*20f, transform.rotation);
                        break;
                    case 2:
                        GameObject UFO = Instantiate(ufo, transform.position + transform.forward*10f + transform.up*20f, transform.rotation);
                        break;
                }

            }

            if (Input.GetKey("escape"))
            {
                Cursor.lockState = CursorLockMode.None;
            }
        }
    }

}
