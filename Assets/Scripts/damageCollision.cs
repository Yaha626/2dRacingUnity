using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class damageCollision : MonoBehaviour
{
    public int _collisionDamage;

    public string _collisionTag;

    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == _collisionTag)
        {
            _collisionDamage = collision.gameObject.GetComponent<WeaponsStats>()._damage;
            CarCondition _currentHealth = collision.gameObject.GetComponent<CarCondition>();
            //_currentHealth.TakeDamage();
            _currentHealth.TakeDamage(_collisionDamage);
        }
    }
}
