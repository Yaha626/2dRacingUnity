using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class damageCollision : MonoBehaviour
{
    //public int _collisionDamage = 10;

    //public string _collisionTag;

    private CarCondition carCondition;

    private int _bulletGunDamage = 10;

    private int _rocketGunDamage = 50;



    public void OnCollisionEnter2D(Collision2D collision)
    {



        carCondition = GetComponent<CarCondition>(); 
        
    
        if (collision.gameObject.tag == "bulletGun")
        {

            GetComponent<CarCondition>().TakeDamage(_bulletGunDamage);           
        }

        if(collision.gameObject.tag == "rocketGun")        
        {
        
            GetComponent<CarCondition>().TakeDamage(_rocketGunDamage);
        }
    }
}
