using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InitiateConversation : MonoBehaviour
{



    public bool state;

    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        CheckState();
    }


    void CheckState()
    {

        if (GetComponent<GlobalCheck>().check && Input.GetKeyDown(KeyCode.Space))
        {
            state = !state;
            ChangeState();
        }


    }


    void ChangeState()
    {
        if (state)
        {
            transform.GetChild(0).gameObject.SetActive(true);
        }
        else
        {
            transform.GetChild(0).gameObject.SetActive(false);
        }
    }

}
