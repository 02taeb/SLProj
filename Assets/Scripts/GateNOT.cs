using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GateNOT : Gate
{
    // Start is called before the first frame update
    void Start()
    {
        if (inputs.Count != 1)
        {
            inputs.Clear();
            inputs.Add(false);
        }
    }

    public override void Predicate()
    {
        output = !inputs[0];
    }
}
