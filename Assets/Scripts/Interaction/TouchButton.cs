using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;
using UnityEngine.Events;

public class TouchButton : XRBaseInteractable
{
    public UnityEvent OnPress = null;

    [SerializeField] string buttonID;
    private XRBaseInteractor hoverInteractor;
    private float previousHandHeight;
    float yMin = 0f;
    float yMax = 0f;
    private bool priorPress = false;

    protected override void Awake()
    {
        base.Awake();
        onHoverEntered.AddListener(StartPress);
        onHoverExited.AddListener(EndPress);
    }

    void OnDestroy()
    {
        onHoverEntered.RemoveListener(StartPress);
        onHoverExited.RemoveListener(EndPress);
    }

    void Start()
    {
        setMinMax();
    }

    void StartPress(XRBaseInteractor interactor)
    {
        hoverInteractor = interactor;
        previousHandHeight = interactor.transform.position.y;
    }

    void EndPress(XRBaseInteractor interactor)
    {
        hoverInteractor = null;
        previousHandHeight = 0f;

        priorPress = false;
        SetY(yMax);
    }

    void setMinMax()
    {
        Collider collider = GetComponent<Collider>();
        yMin = transform.localPosition.y - (collider.bounds.size.y * 0.5f);
        yMax = transform.localPosition.y;
    }

    float GetLocalY(Vector3 position)
    {
        Vector3 localPosition = transform.root.InverseTransformPoint(position);
        return localPosition.y;
    }

    void SetY(float position)
    {
        Vector3 newPos = transform.localPosition;
        newPos.y = Mathf.Clamp(position, yMin, yMax);
        transform.localPosition = newPos;
    }

    void CheckPress()
    {
        bool inPosition = InPosition();
        if(inPosition && inPosition != priorPress)
        {
            OnPress.Invoke();
        }
        priorPress = inPosition;
    }

    bool InPosition()
    {
        float inRange = Mathf.Clamp(transform.localPosition.y, yMin, yMin+0.01f);
        return transform.localPosition.y == inRange;
    }

    public override void ProcessInteractable(XRInteractionUpdateOrder.UpdatePhase updatePhase)
    {
        if(hoverInteractor)
        {
            float newHandHeight = GetLocalY(hoverInteractor.transform.position);
            float handDifference = previousHandHeight - newHandHeight;
            previousHandHeight = newHandHeight;

            float newPosition = transform.localPosition.y - handDifference;
            SetY(newPosition);

            CheckPress();
        }
    }
}
