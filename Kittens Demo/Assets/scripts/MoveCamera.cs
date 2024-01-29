using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCamera : MonoBehaviour
{
    // Start is called before the first frame update
    public float speed = 0.1f;
    void Update()
    {
        if (Input.GetKey("w"))
        {
            transform.position=transform.position+transform.forward*speed;
        }
        if (Input.GetKey("s"))
        {
            transform.position=transform.position+transform.forward*-speed;
        }
        if (Input.GetKey("d"))
        {
            transform.position=transform.position+transform.right*speed;
        }
        if (Input.GetKey("a"))
        {
            transform.position=transform.position+transform.right*-speed;
        }
    }


}
