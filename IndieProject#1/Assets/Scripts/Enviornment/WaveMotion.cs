using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaveMotion : MonoBehaviour
{


    public GameObject top;
    public GameObject bottom;

    private Vector3 newTop;
    private Vector3 newBottom;

    public float speed;

    private float interp;

    // Start is called before the first frame update
    void Start()
    {
        interp = 0;

        newTop = transform.position;
        newBottom = new Vector3(transform.position.x, bottom.transform.position.y, bottom.transform.position.z);

    }

    // Update is called once per frame
    void Update()
    {
        interp = interp + (speed * Time.deltaTime);
        transform.position = Vector3.Lerp(newTop, newBottom, interp);
        if(transform.position == newBottom)
        {
            Destroy(gameObject);
        }
    }
}
