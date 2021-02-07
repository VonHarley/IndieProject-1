using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShadowCasting : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < transform.childCount; i++)
        {

                transform.GetChild(i).GetComponent<SpriteRenderer>().shadowCastingMode = UnityEngine.Rendering.ShadowCastingMode.On;
            
        }
       
            
    }


}
