using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class laser_script : MonoBehaviour
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
        Destroy(gameObject);

    }
}
