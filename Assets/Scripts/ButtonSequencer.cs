using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class ButtonSequencer : MonoBehaviour
{
    [SerializeField] string[] masterSequence;
    int step;
    string[] inputSequence;

    public UnityEvent OnSequenceReset = null;
    public UnityEvent OnNextStep = null;
    public UnityEvent OnSequenceComplete = null;

    // Start is called before the first frame update
    void Start()
    {
        inputSequence = new string[masterSequence.Length];
        step = 0;
    }

    public void addToSequence(string id)
    {
        inputSequence[step] = id;
        checkSequence();
    }

    void checkSequence()
    {
        for(int index = 0; index <= step; index++)
        {
            if(masterSequence[index] != inputSequence[index])
            {
                resetSequence();
                return;
            }
        }
        step++;
        OnNextStep.Invoke();
        if(step >= masterSequence.Length)
        {
            sequenceComplete();
        }
    }

    void resetSequence()
    {
        inputSequence = new string[masterSequence.Length];
        step = 0;
        OnSequenceReset.Invoke();
    }

    void sequenceComplete()
    {
        OnSequenceComplete.Invoke();
        this.enabled = false;
    }
}
