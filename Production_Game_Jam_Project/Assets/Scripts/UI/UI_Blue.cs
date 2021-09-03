using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI_Blue : MonoBehaviour
{
    [SerializeField]
    Sprite switchOn;

    [SerializeField]
    Sprite switchOff;
    public Image blue_UI;
    public bool isOn = false;

    void Start()
    {
        blue_UI.sprite = switchOff;



    }

    void Update()
    {
        if (GameObject.Find("Blue_door").GetComponent<B_door>().isOpen == true)
        {
            blue_UI.sprite = switchOn;

            isOn = true;

        }
        if (GameObject.Find("Blue_door").GetComponent<B_door>().isOpen == false)
        {
            blue_UI.sprite = switchOff;

            isOn = false;

        }
    }
}
