using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button_4 : MonoBehaviour
{
    [SerializeField]
    GameObject switchOn;

    [SerializeField]
    GameObject switchOff;

    public bool isOn = false;

    void Start()
    {
        gameObject.GetComponent<SpriteRenderer>().sprite = switchOff.GetComponent<SpriteRenderer>().sprite;


    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha4))

        {
            gameObject.GetComponent<SpriteRenderer>().sprite = switchOn.GetComponent<SpriteRenderer>().sprite;
            isOn = true;
            StartCoroutine(("SetMyBoolToFalse"));

        }




        if (isOn)
        {
            if (Input.GetKeyDown(KeyCode.Alpha7))

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
}
