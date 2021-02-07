using System.Collections;
using System.Collections.Generic;
using UnityEngine;



[ExecuteAlways]
public class WaveColor : MonoBehaviour
{

    public Vector2 minMax;

    public Color[] oceanColor;
    public Color dayTimeColor;

    public Color cur;

    public GameObject whiteOut;

    private float order;
    private float ratio;
    public float orderSpace;

    public float test;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        IdentifyOrder();
        IdentifyColor();
        
    }

    void IdentifyColor()
    {
        float degree = Mathf.Abs(minMax.x - (minMax.x - (Mathf.Abs(minMax.x - minMax.y) / 7))) / Mathf.Abs(minMax.x - minMax.y);
        int colorStage = (int)((ratio * (Mathf.Abs(minMax.x - minMax.y) / 7)) / degree);

        print(degree);
        print("test");
        test =((ratio * (Mathf.Abs(minMax.x - minMax.y) / 7)) % degree)/degree;
        cur = Color.Lerp(cur, oceanColor[colorStage], test);
        whiteOut.GetComponent<SpriteRenderer>().color = cur;
    }

    void IdentifyOrder()
    {
        float distance = Mathf.Abs(minMax.x - minMax.y);
        ratio = Mathf.Abs(minMax.x - transform.position.y)/Mathf.Abs(minMax.x - minMax.y);
      //  print (ratio);
        order = ratio * orderSpace;

    //    transform.GetChild(0).GetComponent<SpriteRenderer>().sortingOrder = (int)order;
     //   transform.GetChild(1).GetComponent<SpriteRenderer>().sortingOrder = (int)order;
    }





}
