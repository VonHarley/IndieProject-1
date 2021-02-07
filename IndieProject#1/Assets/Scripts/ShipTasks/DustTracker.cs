using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DustTracker : MonoBehaviour
{


    public GameObject[] dustPiles;
    public float[] dustTimer;
    public float[] growthMultiplier;
    public float duration;

    public Sprite[] dustStages;


    // Start is called before the first frame update
    void Start()
    {
        dustTimer = new float[dustPiles.Length];
        growthMultiplier = new float[dustPiles.Length];
        SetMultiplier();
    }

    // Update is called once per frame
    void FixedUpdate()
    {


        PassTime();
        CheckClean();
        UpdateDirt();

    }


    void PassTime()
    {
        for (int i = 0; i < dustTimer.Length; i++)
        {

            dustTimer[i] = dustTimer[i] + (duration*growthMultiplier[i]);



        }
    }


    void SetMultiplier()
    {
        for (int i = 0; i < growthMultiplier.Length; i++)
        {
            growthMultiplier[i] = Random.Range(0, 10f);
        }
    }


    void ChangeMultiplayer(int slot)
    {

        growthMultiplier[slot] = Random.Range(0, 10f);

    }

    void CheckClean()
    {

        for (int i = 0; i < dustPiles.Length; i++)
        {

            if (dustPiles[i].GetComponent<GlobalCheck>().activate)
            {

                dustTimer[i] = 0;
                ChangeMultiplayer(i);
                dustPiles[i].GetComponent<GlobalCheck>().activate = false;
            }



        }


    }

    void UpdateDirt()
    {

        for (int i = 0; i < dustTimer.Length; i++)
        {

            if (dustTimer[i] < 100)
            {
                dustPiles[i].GetComponent<SpriteRenderer>().sprite = null;
            }
            else if (dustTimer[i] < 200)
            {

                dustPiles[i].GetComponent<SpriteRenderer>().sprite = dustStages[0];
            }
            else if (dustTimer[i] < 300)
            {

                dustPiles[i].GetComponent<SpriteRenderer>().sprite = dustStages[1];
            }
            else
            {
                dustPiles[i].GetComponent<SpriteRenderer>().sprite = dustStages[2];
            }

        }
    }


}
