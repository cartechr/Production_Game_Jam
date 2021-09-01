using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class B_door : MonoBehaviour
{
    [SerializeField]
    GameObject doorOpen;

    [SerializeField]
    GameObject doorClosed;

    public bool isOpen = false;

    void Start()
    {
        gameObject.GetComponent<SpriteRenderer>().sprite = doorClosed.GetComponent<SpriteRenderer>().sprite;
    }


    void Update()
    {
        if (GameObject.Find("B1").GetComponent<Button_1>().isOn == true || GameObject.Find("B2").GetComponent<Button_2>().isOn == true)
        {
            gameObject.GetComponent<SpriteRenderer>().sprite = doorOpen.GetComponent<SpriteRenderer>().sprite;

            isOpen = true;
        }



        if (GameObject.Find("B4").GetComponent<Button_4>().isOn == true)
        {
            gameObject.GetComponent<SpriteRenderer>().sprite = doorClosed.GetComponent<SpriteRenderer>().sprite;

            isOpen = false;
        }

    }
}
