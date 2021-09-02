using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI_red : MonoBehaviour
{
    [SerializeField]
    GameObject switchOn;

    [SerializeField]
    GameObject switchOff;

    public bool isOn = false;

    void Start()
    {
        gameObject.GetComponent<Image>().sprite = switchOff.GetComponent<Image>().sprite;
        


    }

    void Update()
    {
        if (GameObject.Find("Red_door").GetComponent<R_door>().isOpen == true)
        {
            gameObject.GetComponent<Image>().sprite = switchOn.GetComponent<Image>().sprite;

            isOn = true;
           
        }
        if (GameObject.Find("Red_door").GetComponent<R_door>().isOpen == false)
        {
            gameObject.GetComponent<Image>().sprite = switchOn.GetComponent<Image>().sprite;

            isOn = false;

        }
    }
    }
