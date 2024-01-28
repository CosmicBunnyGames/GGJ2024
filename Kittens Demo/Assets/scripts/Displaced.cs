using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Displaced : MonoBehaviour
{
    private Vector3 startPos;
    private bool isDisplaced;
    private float displacementLimit = 1f;
    public Total_Displacement total_Displacement;

    public int scoreAdd;

    // Start is called before the first frame update
    void Start()
    {
        startPos = gameObject.transform.position;
        isDisplaced = false;
        total_Displacement.Displacement_Max=total_Displacement.Displacement_Max+1;
    }

    // Update is called once per frame
    void Update()
    {
        if (!isDisplaced)
        {
            if (Vector3.Distance(startPos, gameObject.transform.position) > displacementLimit)
            {
                isDisplaced = true;
                total_Displacement.Displacement_Total = total_Displacement.Displacement_Total + 1; 
            }
        }
    }
}
