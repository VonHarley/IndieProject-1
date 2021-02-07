using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class interfaceDisplay : MonoBehaviour
{

    public Vector3 hidPos;
    public Vector3 hidRot;
    public Vector3 shoPos;
    public Vector3 shoRot;
    public bool state;
    private float startTime;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if (state)
        {
            transform.localPosition = Vector3.Lerp(transform.localPosition, shoPos, (Time.time - startTime) / 2);
            transform.localEulerAngles = Vector3.Lerp(transform.localEulerAngles, shoRot, (Time.time - startTime) / 2);
        }
        else
        {
            transform.localPosition = Vector3.Lerp(transform.localPosition, hidPos, (Time.time - startTime) / 2);
            transform.localEulerAngles = Vector3.Lerp(transform.localEulerAngles, hidRot, (Time.time - startTime) / 2);
        }

    }



    public void ChangeState()
    {

        state = !state;
        startTime = Time.time;


    }




}
