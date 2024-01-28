using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnUFO : MonoBehaviour
{

    public GameObject UFO;
    void Start()
    {
        GameObject gameObject1 = Instantiate(UFO, transform.position + Vector3.up * 30f, transform.rotation);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
