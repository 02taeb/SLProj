using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GateXOR : Gate
{
    private void Start()
    {
        if (inputs.Count == 0)
        {
            inputs.Add(false);
            inputs.Add(false);
        }
    }

    public override void Predicate()
    {
        bool temp = false;
        for (int i = 0; i < inputs.Count; i++)
        {
            temp ^= inputs[i];
        }
        output = temp;
    }
}
