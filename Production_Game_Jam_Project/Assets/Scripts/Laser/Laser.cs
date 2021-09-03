using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Laser : MonoBehaviour
{
    public Transform firepoint;
    public GameObject laserPrefab;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            Shoot();
           
        }
    }

    void Shoot()
    {
        Instantiate(laserPrefab, firepoint.position, firepoint.rotation);
       
    }

}
