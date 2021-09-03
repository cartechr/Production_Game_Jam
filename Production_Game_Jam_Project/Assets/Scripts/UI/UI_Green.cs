using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI_Green : MonoBehaviour
{
    [SerializeField]
    Sprite switchOn;

    [SerializeField]
    Sprite switchOff;
    public Image green_UI;
    public bool isOn = false;

    void Start()
    {
        green_UI.sprite = switchOff;



    }

    void Update()
    {
        if (GameObject.Find("Green_door").GetComponent<G_door>().isOpen == true)
        {
            green_UI.sprite = switchOn;

            isOn = true;

        }
        if (GameObject.Find("Green_door").GetComponent<G_door>().isOpen == false)
        {
            green_UI.sprite = switchOff;

            isOn = false;

        }
    }
}
