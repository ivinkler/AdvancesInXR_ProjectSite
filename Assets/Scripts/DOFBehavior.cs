using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;
//using UnityEngine.Rendering.HighDefinition;

public class DOFBehavior : MonoBehaviour
{/*
    [SerializeField] GameObject mainCam;
    [SerializeField] Volume vol;
    [SerializeField] float maxFocalDistance = 10f;
    [SerializeField] float minFocalDistance = 0.1f;
    [SerializeField] float focalDist;
    [SerializeField] float refocusSpeed = 100f;
    [SerializeField] DepthOfField dof;


    // Start is called before the first frame update
    void Start()
    {
        mainCam = GameObject.Find("Main Camera");
        vol = GameObject.Find("PostProcessor").GetComponent<Volume>();
        dof = vol.profile.GetSetting<DepthOfField>();
    }

    // Update is called once per frame
    void Update()
    {
        RaycastHit hit;
        Ray focus = new Ray(mainCam.transform.position, Vector3.forward);

        if(Physics.Raycast(focus, out hit))
        {
            if(hit.distance < maxFocalDistance)
            {
                if(hit.distance > minFocalDistance)
                {
                    dof.focusDistance.value = Mathf.Lerp(dof.focusDistance.value, hit.distance, Time.deltaTime * refocusSpeed);
                }
                else
                {
                    dof.focusDistance.value = Mathf.Lerp(dof.focusDistance.value, minFocalDistance, Time.deltaTime * refocusSpeed);
                }
            }
            else
            {
                dof.focusDistance.value = Mathf.Lerp(dof.focusDistance.value, maxFocalDistance, Time.deltaTime * refocusSpeed);
            }

            //Debug.Log(hit.distance);
        }

        
    }
  */  
}
