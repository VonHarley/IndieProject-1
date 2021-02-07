using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controlls : MonoBehaviour
{

    public GameObject gravityChecker;

    public float speed;
    public float gravity;
    public float iteration;

    public Vector3 futurePosition;


    public GameObject[] InterfaceObjects;
    public GameObject[] shipInteractables;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        GrabPosition();
        CheckInputsCharacter();
        CauseGravity();
        SetPosition();

        CheckDisplayInterface();

    }


    void GrabPosition()
    {
        futurePosition = transform.position;
    }

    void CauseGravity()
    {

        if (gravityChecker.GetComponent<CheckCollide>().collision == false)
        {
            iteration = iteration + 1;
            futurePosition = new Vector3(futurePosition.x, futurePosition.y - gravity * iteration, futurePosition.z);

        }
        else
        {
            iteration = 1;
            futurePosition = new Vector3(futurePosition.x, futurePosition.y + gravity, futurePosition.z);
        }

    }


    void SetPosition()
    {
        transform.position = futurePosition;
    }


    void CheckInputsCharacter()
    {

        if (Input.GetKey(KeyCode.A))
        {
            futurePosition = new Vector3(futurePosition.x - speed, futurePosition.y, futurePosition.z);
        }
        if (Input.GetKey(KeyCode.D))
        {
            futurePosition = new Vector3(futurePosition.x + speed, futurePosition.y, futurePosition.z);
        }
        if (Input.GetKey(KeyCode.W))
        {
            futurePosition = new Vector3(futurePosition.x, futurePosition.y, futurePosition.z + speed);
        }
        if (Input.GetKey(KeyCode.S))
        {
            futurePosition = new Vector3(futurePosition.x, futurePosition.y, futurePosition.z - speed);
        }
        if (Input.GetKey(KeyCode.Escape))
        {
            Application.Quit();
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            SortInteractable();
        }
    }


    void SortInteractable()
    {

        for (int i = 0; i < shipInteractables.Length; i++)
        {

            if (shipInteractables[i].GetComponent<GlobalCheck>().check)
            {
                shipInteractables[i].GetComponent<GlobalCheck>().activate = true;
            }


        }

    }


    void CheckDisplayInterface()
    {
        if (Input.GetKey(KeyCode.Tab))
        {
            InterfaceObjects[0].GetComponent<interfaceDisplay>().ChangeState();
        }

    }



}
