using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class damageCollision : MonoBehaviour
{
    public int _collisionDamage = 10;

    public string _collisionTag;

    private CarCondition carCondition;

    public void OnCollisionEnter2D(Collision2D collision)
    {
        carCondition = GetComponent<CarCondition>();
        
        
    
        if (collision.gameObject.tag == _collisionTag)
        {
            GetComponent<CarCondition>().TakeDamage(_collisionDamage);
         //   carCondition
           // _collisionDamage = collision.gameObject.GetComponent<WeaponsStats>()._damage;
           // CarCondition _currentHealth = collision.gameObject.GetComponent<CarCondition>();
            //_currentHealth.TakeDamage();
          //  _currentHealth.TakeDamage(_collisionDamage);
        }
    }
}
