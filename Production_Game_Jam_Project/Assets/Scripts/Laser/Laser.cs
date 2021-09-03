using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Laser : MonoBehaviour
{
    public Transform firepoint;
    public GameObject laserPrefab;
    public Animator animator;
    public AudioSource audiosource;
    public AudioClip sound;


    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            Shoot();
            animator.SetBool("IsShooting", true);
            audiosource.PlayOneShot(sound);
           
        }
        else
        {
            animator.SetBool("IsShooting", false);
        }
    }

    void Shoot()
    {
        Instantiate(laserPrefab, firepoint.position, firepoint.rotation);
       
    }

}
