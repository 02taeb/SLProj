using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Matrix : MonoBehaviour
{
    List<string> strings= new List<string>();

    // Update is called once per frame
    void Update()
    {
        foreach (string s in strings)
        {
            for (int i = 0; i < s.Length; i++)
            {
                s[i] = ((Random.RandomRange(0, 100) % 2 == 0) ? '0' : '1';
            }
        }
    }
}
