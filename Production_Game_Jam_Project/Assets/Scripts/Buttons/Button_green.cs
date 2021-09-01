using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button_green : MonoBehaviour
{
    [SerializeField]
    GameObject switchOn;

    [SerializeField]
    GameObject switchOff;

    public bool isOn = false;

    void Start()
    {
        gameObject.GetComponent<SpriteRenderer>().sprite = switchOff.GetComponent<SpriteRenderer>().sprite;
        print(isOn);

    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))

        {
            gameObject.GetComponent<SpriteRenderer>().sprite = switchOn.GetComponent<SpriteRenderer>().sprite;
            isOn = true;
            print(isOn);
        }




        if (isOn)
        {
            if (Input.GetKeyDown(KeyCode.W))

            {
                gameObject.GetComponent<SpriteRenderer>().sprite = switchOff.GetComponent<SpriteRenderer>().sprite;
                isOn = false;
            }




        }


    }

}
