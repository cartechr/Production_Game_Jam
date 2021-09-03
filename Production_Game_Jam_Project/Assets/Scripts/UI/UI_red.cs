using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI_red : MonoBehaviour
{
    [SerializeField]
    Sprite switchOn;

    [SerializeField]
    Sprite switchOff;
    public Image red_UI;
    public bool isOn = false;

    void Start()
    {
        red_UI.sprite = switchOff;
        


    }

    void Update()
    {
        if (GameObject.Find("Red_door").GetComponent<R_door>().isOpen == true)
        {
            red_UI.sprite = switchOn;

            isOn = true;
           
        }
        if (GameObject.Find("Red_door").GetComponent<R_door>().isOpen == false)
        {
            red_UI.sprite = switchOff;

            isOn = false;

        }
    }
    }
