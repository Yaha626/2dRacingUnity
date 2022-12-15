using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CarCondition : MonoBehaviour
{
    [Header ("Health")]

    public int _maxHealth = 100;

    public int _currentHealth = 100;


    public void TakeDamage(int _damage)
    {
        _currentHealth -= _damage;
        
        if(_currentHealth <= 0)
        {
            Destroy(gameObject);
        }
    }
    

    public void SetHealth(int _bonusHealth)
    {
        _currentHealth += _currentHealth;

        if(_currentHealth > _maxHealth)
        {
            _currentHealth = _maxHealth;
        }
    }
}
