using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button_1 : MonoBehaviour
{
    [SerializeField]
    GameObject switchOn;

    [SerializeField]
    GameObject switchOff;

    public bool isOn = false;
    public bool isInRange;
    public AudioSource audiosource;
    public AudioClip sound;


    void Start()
    {
        gameObject.GetComponent<SpriteRenderer>().sprite = switchOff.GetComponent<SpriteRenderer>().sprite;


    }

    void Update()
    {

        if (isInRange)
        {
            if (Input.GetKeyDown(KeyCode.E) && isOn == false)
            {


                {
                    gameObject.GetComponent<SpriteRenderer>().sprite = switchOn.GetComponent<SpriteRenderer>().sprite;
                    isOn = true;
                    StartCoroutine(("SetMyBoolToFalse"));
                    audiosource.PlayOneShot(sound);
                }


                if (Input.GetKeyDown(KeyCode.E) && isOn == true)

                {
                    gameObject.GetComponent<SpriteRenderer>().sprite = switchOn.GetComponent<SpriteRenderer>().sprite;
                    isOn = true;
                    StartCoroutine(("SetMyBoolToFalse"));
                }
            }

        }

        if (isOn)
        {
            if (Input.GetKeyDown(KeyCode.Alpha0))

            {
                gameObject.GetComponent<SpriteRenderer>().sprite = switchOff.GetComponent<SpriteRenderer>().sprite;
                isOn = false;
              
            }




        }
        

        

    }
    private IEnumerator SetMyBoolToFalse()
    {

        yield return new WaitForSeconds(1f);
        if (isOn == true)
        {
            isOn = false;
            gameObject.GetComponent<SpriteRenderer>().sprite = switchOff.GetComponent<SpriteRenderer>().sprite;
        }
        yield return null;
    }
     void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.CompareTag("Player"))
        {
            isInRange = true;
            Debug.Log("Player in 1");
        }
    }
     void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            isInRange = false;
            Debug.Log("Player out 1 ");
        }
    }

}
