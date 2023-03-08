using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Matrix : MonoBehaviour
{
    public List<Text> texts = new List<Text>();
    float timer = 0;
    public float threshold = 0.5f;

    // Update is called once per frame
    void FixedUpdate()
    {
        timer += Time.deltaTime;
        if (timer > threshold)
        {
            timer = 0;
            Debug.Log("If");
            for (int i = 0; i < texts.Count; i++)
            {
                string temp = texts[i].text;
                char[] chars= temp.ToCharArray();
                temp = "";
                for (int j = 0; j < chars.Length; j++)
                {
                    chars[j] = (Random.Range(0, 100) % 2 == 0) ? '0' : '1';
                    temp += chars[j].ToString();
                }
                texts[i].text = temp;
            }
        }
    }
}
