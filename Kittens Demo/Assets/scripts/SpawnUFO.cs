using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class SpawnUFO : MonoBehaviour
{
    public GameObject UFO;

    void Shoot()
    {
        GameObject gameObject1 = Instantiate(UFO, transform.position + Vector3.up * 30f, transform.rotation);
    }
}
