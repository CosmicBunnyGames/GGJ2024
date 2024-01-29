using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Script : MonoBehaviour
{
    Vector3 Angles;
    public float sensitivityX;
    public float sensitivityY;
    public GameObject pivot;
    public GameObject feuerwerk;
    public GameObject rocrap = transform.GetComponent<Rocket>();
    public GameObject anvil = transform.GetComponent<Anvil>();
    public GameObject[] weapons;
    void Start(){
        weapons[0] = rocrap;
    }
    void Update()
    {
        if (Cursor.lockState == CursorLockMode.None){
            if (Input.GetMouseButton(0)){
                Cursor.lockState = CursorLockMode.Locked;
            }
        }else{
            float rotationY = Input.GetAxis("Mouse Y") * sensitivityX;
            float rotationX = Input.GetAxis("Mouse X") * sensitivityY;

            if (rotationY > 0)
                Angles = new Vector3(Mathf.MoveTowards(Angles.x, -80, rotationY), Angles.y + rotationX, 0);
            else
                Angles = new Vector3(Mathf.MoveTowards(Angles.x, 80, -rotationY), Angles.y + rotationX, 0);
            transform.localEulerAngles = new Vector3(0,Angles.y,0);
            pivot.transform.localEulerAngles = new Vector3(Angles.x,0,0);
        
            if (Input.GetMouseButton(0)){
                int rngWeap = Random.Range(0, weapons.length);
                weapons[rngWeap].Shoot();
            }

            if (Input.GetKey("escape")){
                Cursor.lockState = CursorLockMode.None;
            }
        }
    }

}
