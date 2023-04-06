using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GateMulti : MonoBehaviour
{
    public GateMulti inputComp1, inputComp2;
    public LineRenderer outputLine;
    private bool input1, input2;
    private bool output;
    private Dropdown dropdown;

    private void Start()
    {
        dropdown = GetComponent<Dropdown>();    
    }

    
    void FixedUpdate()
    {
        SetInputs();

        switch (dropdown.value)
        {
            case 0:
                output = false; // if default value, should not output true
                break;
            case 1:
                output = input1; // if wire, should output singular input
                break;
            case 2:
                output = input1 && input2; // if AND, output AND of inputs
                break;
            case 3:
                output = !input1; // if NOT, output Negation of singular input
                break;
            case 4:
                output = input1 ^ input2; // if XOR, output XOR of inputs
                break;
        }
        SetOutputLine(output);
    }

    private void SetInputs()
    {
        if (inputComp1 == null)
            input1 = transform.name[0] == 't';
        else
            input1 = inputComp1.GetOutput();
        if (inputComp2 == null)
            input2 = transform.name[1] == 't';
        else
            input2 = inputComp2.GetOutput();
    }

    public bool GetOutput()
    {
        return output;
    }

    private void SetOutputLine(bool b)
    {
        if (b)
        {
            outputLine.startColor = Color.green;
            outputLine.endColor = Color.green;
        }
        else
        {
            outputLine.startColor = Color.red;
            outputLine.endColor = Color.red;
        }
    }
}
