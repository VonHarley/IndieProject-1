using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OceanController : MonoBehaviour
{

    public GameObject top;
    public GameObject bottom;

    public GameObject wave;
    public float waveMagnitude;
    private GameObject sea;
    // Start is called before the first frame update
    void Start()
    {
        sea = new GameObject();
        sea.name = "Sea";
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public void CreateWave()
    {
        
        
        for (int i = -3; i < 4; i++)
        {
            Vector3 pos = top.transform.position;
            pos.x = pos.x + (i*waveMagnitude);

            GameObject newWave = Instantiate(wave, pos, top.transform.localRotation);
            newWave.GetComponent<WaveMotion>().top = top;
            newWave.GetComponent<WaveMotion>().bottom = bottom;
            newWave.GetComponent<WaveColor>().minMax.x = top.transform.position.y;
            newWave.GetComponent<WaveColor>().minMax.y = bottom.transform.position.y;
            newWave.transform.parent = sea.transform;
        }



    }


}
