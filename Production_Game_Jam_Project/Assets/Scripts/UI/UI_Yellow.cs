using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI_Yellow : MonoBehaviour
{
    [SerializeField]
    Sprite switchOn;

    [SerializeField]
    Sprite switchOff;
    public Image yellow_UI;
    public bool isOn = false;

    void Start()
    {
        yellow_UI.sprite = switchOff;



    }

    void Update()
    {
        if (GameObject.Find("Yellow_door").GetComponent<Y_door>().isOpen == true)
        {
            yellow_UI.sprite = switchOn;

            isOn = true;

        }
        if (GameObject.Find("Yellow_door").GetComponent<Y_door>().isOpen == false)
        {
            yellow_UI.sprite = switchOff;

            isOn = false;

        }
    }
}
