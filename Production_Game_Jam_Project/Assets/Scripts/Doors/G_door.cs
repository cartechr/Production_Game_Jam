using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class G_door : MonoBehaviour
{
    [SerializeField]
    GameObject doorOpen;

    [SerializeField]
    GameObject doorClosed;
    public BoxCollider2D collider2D;
    public bool isOpen = false;

    void Start()
    {
        gameObject.GetComponent<SpriteRenderer>().sprite = doorClosed.GetComponent<SpriteRenderer>().sprite;
    }


    void Update()
    {
        if (GameObject.Find("B4").GetComponent<Button_4>().isOn == true )
        {
            gameObject.GetComponent<SpriteRenderer>().sprite = doorOpen.GetComponent<SpriteRenderer>().sprite;

            isOpen = true;
            SetInActive();
        }



        if (GameObject.Find("B3").GetComponent<Button_3>().isOn == true || GameObject.Find("B2").GetComponent<Button_2>().isOn == true)
        {
            gameObject.GetComponent<SpriteRenderer>().sprite = doorClosed.GetComponent<SpriteRenderer>().sprite;

            isOpen = false;
            SetActive();
        }

    }
    void SetInActive()
    {
        collider2D.enabled = false;


    }
    void SetActive()
    {
        collider2D.enabled = true;

    }
}
