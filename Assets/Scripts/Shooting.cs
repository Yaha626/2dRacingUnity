using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{
    public Transform firePoint;

    public GameObject bulletPrefab;

    public float bulletForce = 20f;

    public float bulletTimeInterval = 0.15f;

    public float bulletIntervalCount = 0f;


    public AudioSource shooting;


    // Update is called once per frame
    void Update()
    {
        bulletIntervalCount += Time.deltaTime;
        if (Input.GetKey(KeyCode.Space))
        {
          if(bulletIntervalCount >= bulletTimeInterval)
            {
                bulletIntervalCount = 0;
                Shoot();
                shooting.Play();
            }                        
        }
    }

    void Shoot()
    {
        GameObject boolet = Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
        Rigidbody2D rb = boolet.GetComponent<Rigidbody2D>();
        rb.AddForce(firePoint.up * bulletForce, ForceMode2D.Impulse);

    }
}
