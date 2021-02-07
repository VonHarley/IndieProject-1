using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GlobalCheck : MonoBehaviour
{


    public bool check;
    public bool activate;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }



    private void OnTriggerEnter(Collider other)
    {

            check = true;
        
    }

    private void OnTriggerExit(Collider other)
    {

            check = false;
        
    }

}
