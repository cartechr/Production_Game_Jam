using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Laser_Script1 : MonoBehaviour
{
    public float speed = 20f;
    public int damage = 1;
    public Rigidbody2D rb;
    void Start()
    {
        rb.velocity = transform.right * speed;
    }

    private void OnTriggerEnter2D(Collider2D hitInfo)
    {
        Box box = hitInfo.GetComponent<Box>();

        if (box != null)
        {
            box.TakeDamage(damage);
        }
        if (hitInfo.gameObject.CompareTag("Player"))
        {

        }
        Destroy(gameObject);
    }
}
