using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.XR;

public class PzlNOT : MonoBehaviour
{
    public GateNOT outp;
    public LineRenderer lineA, lineB;
    public Dropdown A, B;

    // Update is called once per frame
    void FixedUpdate()
    {
        // inputs för övre är output från nedre
        switch (A.value)
        {
            case 0:
                // Debug.Log("LineA def");
                lineA.startColor = Color.red;
                lineA.endColor = Color.red;
                break;
            case 1:
                // Debug.Log("LineA red");
                lineA.startColor= Color.red;
                lineA.endColor= Color.red;
                break;
            case 2:
                // Debug.Log("LineA green");
                lineA.startColor= Color.green;
                lineA.endColor= Color.green;
                break;
        }
        switch (B.value)
        {
            case 0:
                // Debug.Log("LineB def");
                lineB.startColor = Color.red;
                lineB.endColor = Color.red;
                break;
            case 1:
                // Debug.Log("LineB green");
                lineB.startColor = Color.green;
                lineB.endColor = Color.green;
                break;
            case 2:
                // Debug.Log("LineB red");
                lineB.startColor = Color.red;
                lineB.endColor = Color.red;
                break;
        }
        if (A.value == 2 && B.value == 1)
            outp.SetInputs("f");
        else
            outp.SetInputs("t");
    }
}
