using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.XR;

public class PzlXOR : MonoBehaviour
{
    public GateXOR outp;
    public LineRenderer lineA, lineB;
    public Dropdown A, B;

    // Update is called once per frame
    void FixedUpdate()
    {
        switch (B.value)
        {
            case 0:
                // Debug.Log("LineB def");
                lineB.startColor = Color.red;
                lineB.endColor = Color.red;
                break;
            case 1:
                // Debug.Log("LineB green");
                lineB.startColor = Color.red;
                lineB.endColor = Color.red;
                break;
            case 2:
                // Debug.Log("LineB red");
                lineB.startColor = Color.green;
                lineB.endColor = Color.green;
                break;
        }
        if (B.value == 2) 
        { 
            if (A.value == 2)
            {
                lineA.startColor = Color.green;
                lineA.endColor = Color.green;
            }
            else
            {
                lineA.startColor = Color.red;
                lineA.endColor = Color.red;
            }
        }
        else
        {
            lineA.startColor = Color.red;
            lineA.endColor = Color.red;
        }
        
        if (A.value == 2 && B.value == 2)
            outp.SetInputs("tf");
        else
            outp.SetInputs("ff");
    }
}
