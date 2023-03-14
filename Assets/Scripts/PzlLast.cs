using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.XR;

public class PzlLast : MonoBehaviour
{
    public GateAND outp;
    public List<GateMulti> inputs = new List<GateMulti>();

    // Update is called once per frame
    void FixedUpdate()
    {
        string temp = "";
        foreach (GateMulti gate in inputs)
        {
            if (gate.GetOutput())
                temp += "t";
            else
                temp += "f";
        }
        outp.SetInputs(temp);
    }
}
