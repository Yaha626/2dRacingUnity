using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public GameObject hitEffect;

    private void OnCollisionEnter2D(Collision2D collision)
    {

        GameObject effect =  Instantiate(hitEffect, transform.position, transform.rotation);
        Destroy(effect, 5f);
        Destroy(gameObject); 

    }

    void Awake()
    {

        Invoke("DestroyBullet", 5f);

    }

    public void DestroyBullet()
    {

        Destroy(gameObject);

    }
}
