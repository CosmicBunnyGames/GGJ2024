using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
 
public class Counter : MonoBehaviour {
    public TMP_Text textMeshPro;
    public Total_Displacement totdisp;

    void Update(){

        textMeshPro.text = "you've broken " + totdisp.Displacement_Total + " objects.";
    }
}