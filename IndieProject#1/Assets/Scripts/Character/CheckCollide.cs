using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckCollide : MonoBehaviour
{


    public bool collision;
    public int intersections;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        CheckInteresection();
    }


    private void OnTriggerEnter(Collider other)
    {

        if (other.gameObject.tag == "Ground")
        {
            intersections++;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Ground")
        {
            intersections--;
        }
    }

    void CheckInteresection()
    {
        if (intersections > 0)
        {
            collision = true;

        }
        else
        {
            collision = false;
        }
    }

}
