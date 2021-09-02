using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test_Door : MonoBehaviour
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
        if (GameObject.Find("Button_test").GetComponent<Button>().isOn == true)
            {
            gameObject.GetComponent<SpriteRenderer>().sprite = doorOpen.GetComponent<SpriteRenderer>().sprite;

            isOpen = true;
            SetInActive();
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
