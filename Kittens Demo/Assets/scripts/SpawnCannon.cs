using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class SpawnCannon : MonoBehaviour
{
    public GameObject cannon;

     void Shoot()
    {
        GameObject gameObject1 = Instantiate(cannon, transform.position + Vector3.forward*3f, Quaternion.AngleAxis(90, Vector3.forward));
    }
}
