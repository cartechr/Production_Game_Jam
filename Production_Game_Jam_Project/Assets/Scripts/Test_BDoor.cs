using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test_BDoor : MonoBehaviour
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
        if (GameObject.Find("Button_test").GetComponent<Button>().isOn == true)
        {
            gameObject.GetComponent<SpriteRenderer>().sprite = doorOpen.GetComponent<SpriteRenderer>().sprite;

            isOpen = true;
        }

        if (GameObject.Find("Button_test").GetComponent<Button>().isOn == false)
        {
            gameObject.GetComponent<SpriteRenderer>().sprite = doorClosed.GetComponent<SpriteRenderer>().sprite;

            isOpen = false;
        }

    }
}
