using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public abstract class Gate : MonoBehaviour
{
    public Image outputIMG;
    public GameObject lineParent;
    public List<GameObject> btns = new List<GameObject>();
    protected List<bool> inputs = new List<bool>();
    protected bool output = false;

    public abstract void Predicate();

    private void FixedUpdate()
    {
        Predicate();
        if (output)
            outputIMG.color = Color.green;
        else
            outputIMG.color = Color.red;
    }

    public void SetInputs(string inputStr)
    {
        inputs.Clear();
        foreach (char c in inputStr.ToLower())
        {
            switch (c)
            {
                case 'f': // false/falskt
                case '0': // false
                    inputs.Add(false);
                    break;
                case 's': // sant
                case '1': // true
                case 't': // true
                    inputs.Add(true);
                    break;
                default:
                    inputs.Clear();
                    throw new ArgumentException("inputStr should be one letter (t/f) per input");
            }
        }
    }

    public bool GetOutput()
    {
        return output;
    }

    private void InputTrue(int index)
    {
        inputs[index] = true;
        btns[index].GetComponentInChildren<Text>().text = $"#{index}: On";
        lineParent.transform.GetChild(index + 1).GetComponent<LineRenderer>().startColor = Color.green;
        lineParent.transform.GetChild(index + 1).GetComponent<LineRenderer>().endColor = Color.green;
    }

    private void InputFalse(int index)
    {
        inputs[index] = false;
        btns[index].GetComponentInChildren<Text>().text = $"#{index}: Off";
        lineParent.transform.GetChild(index + 1).gameObject.GetComponent<LineRenderer>().startColor = Color.red;
        lineParent.transform.GetChild(index + 1).gameObject.GetComponent<LineRenderer>().endColor = Color.red;
    }

    private void InputToggle(int index)
    {
        if (inputs[index])
            InputFalse(index);
        else
            InputTrue(index); 
    }

    public void OnPress(GameObject sender)
    {
        InputToggle(int.Parse(sender.name));
    }
}
