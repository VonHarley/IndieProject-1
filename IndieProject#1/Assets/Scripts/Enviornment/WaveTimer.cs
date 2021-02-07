using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaveTimer : MonoBehaviour
{

    public float timer;
    private float activeTime;



    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (activeTime < 0)
        {
            timeTrigger();
            activeTime = timer;
        }
        activeTime = activeTime - Time.deltaTime;
    }



    void timeTrigger()
    {
        gameObject.GetComponent<OceanController>().CreateWave();
    }


}
