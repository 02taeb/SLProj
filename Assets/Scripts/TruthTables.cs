using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class TruthTables : MonoBehaviour
{
    public Dropdown A, B;
    public Text txtA, feedback;
    public Button done;
    public GameObject badge;
    public Image output;
    private const string TXT_A = "0 | 1 | ";

    // Update is called once per frame
    void FixedUpdate()
    {
        switch (SceneManager.GetActiveScene().buildIndex)
        {
            case 2:
                PzlNOT();
                break;
            case 4:
                PzlAND();
                break;
            case 6:
                PzlXOR();
                break;
            case 7:
                PzlLast();
                break;
        }
    }

    public void PzlNOT()
    {
        if (A.value == 2 && B.value == 1)
        {
            txtA.text = TXT_A + "1";
            feedback.text = "Correct!";
            done.gameObject.SetActive(true);
        }
        else
        {
            txtA.text = TXT_A + "0";
            feedback.text = "Incorrect!";
            done.gameObject.SetActive(false);
        }
    }

    public void PzlAND()
    {
        if (A.value == 2 && B.value == 2)
        {
            txtA.text = TXT_A + "1 | 1";
            feedback.text = "Correct!";
            done.gameObject.SetActive(true);
        }
        else
        {
            txtA.text = TXT_A + "1 | 0";
            feedback.text = "Incorrect!";
            done.gameObject.SetActive(false);
        }
    }

    public void PzlXOR()
    {
        if (A.value == 2 && B.value == 2)
        {
            txtA.text = "0 | 0 | 1 | 1";
            feedback.text = "Correct!";
            done.gameObject.SetActive(true);
        }
        else
        {
            txtA.text = "0 | 0 | 1 | 1";
            feedback.text = "Incorrect!";
            done.gameObject.SetActive(false);
        }
    }

    public void PzlLast()
    {
        if (output.color == Color.green)
        {
            txtA.text = "1 | 0 | 1 | 0 | 1 | 1 | 0 | 1 | 1 | 1 | 1";
            feedback.text = "Correct!";
            done.gameObject.SetActive(true);
        }
        else
        {
            txtA.text = "1 | 0 | 1 | 0 | 1 | 1 | 0 | 1 | 1 | 1 | 0";
            feedback.text = "Incorrect!";
            done.gameObject.SetActive(false);
        }
    }

    public void Done()
    {
        badge.SetActive(true);
    }
}
