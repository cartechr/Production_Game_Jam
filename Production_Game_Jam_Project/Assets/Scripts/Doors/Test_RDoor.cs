using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test_RDoor : MonoBehaviour
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
        if (GameObject.Find("Button_test").GetComponent<Button>().isOn == true && GameObject.Find("Test_green_button").GetComponent<Button_green>().isOn == true)
        {
            gameObject.GetComponent<SpriteRenderer>().sprite = doorOpen.GetComponent<SpriteRenderer>().sprite;

            isOpen = true;
        }
        
       

        if (GameObject.Find("Button_test").GetComponent<Button>().isOn == false || GameObject.Find("Test_green_button").GetComponent<Button_green>().isOn == false)
        {
            gameObject.GetComponent<SpriteRenderer>().sprite = doorClosed.GetComponent<SpriteRenderer>().sprite;

            isOpen = false;
        }

    }
}
