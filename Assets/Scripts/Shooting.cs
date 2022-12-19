using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{
    public Transform firePoint;

    public GameObject bulletPrefab;

    public GameObject rocketPrefab;

    public float bulletForce = 20f;

    public float bulletTimeInterval = 0.15f;

    public float bulletIntervalCount = 0f;

    private GameObject _currentWeapon;


    public AudioSource shooting;


    public void Start()
    {
        _currentWeapon = rocketPrefab;
    }


    public void OnTriggerEnter2D(Collider2D collision)
    {


        if (collision.gameObject.tag == "GunDrop")
        {

            _currentWeapon = bulletPrefab;

              bulletForce = 20f;

              bulletTimeInterval = 0.15f;            

        }
        if (collision.gameObject.tag == "RocketDrop")
        {

            _currentWeapon = rocketPrefab;

            bulletForce = 5f;

            bulletTimeInterval = 0.15f;

        }
    }



    void FixedUpdate()
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
        GameObject boolet = Instantiate(_currentWeapon, firePoint.position, firePoint.rotation);
        Rigidbody2D rb = boolet.GetComponent<Rigidbody2D>();
        rb.AddForce(firePoint.up * bulletForce, ForceMode2D.Impulse);

    }
}
