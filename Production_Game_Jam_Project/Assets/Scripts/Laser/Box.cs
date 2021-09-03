using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Box : MonoBehaviour
{
    public int health = 1;

    public GameObject boxHurt;


    public void TakeDamage (int damage)
    {
        health -= damage;

        if (health <= 0)
        {
            Destroy(gameObject);
        }
        if (health == 1)
        {
            gameObject.GetComponent<SpriteRenderer>().sprite = boxHurt.GetComponent<SpriteRenderer>().sprite;
        }
    }
}
