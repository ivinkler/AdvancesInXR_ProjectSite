using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TextCycler : MonoBehaviour
{
    [SerializeField] string[] textScript;
    [SerializeField] TextMeshPro tmp;
    [SerializeField] int index;

    // Start is called before the first frame update
    void Start()
    {
        index = 0;
    }

    public void nextLine()
    {
        if(index+1 >= textScript.Length)
        {
            index = 0;
        }
        else
        {
            index++;
        }
        tmp.text = textScript[index];
    }

    public void getLine(int index)
    {
        tmp.text = textScript[index];
    }
}
