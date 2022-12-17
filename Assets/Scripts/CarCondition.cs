using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CarCondition : MonoBehaviour
{
    [SerializeField] GameObject _explousionOnDeath;

    [Header ("Health")]

    public float _maxHealth = 100f;

    public float _currentHealth = 100f;

    public AudioSource explousion;

   

    public void TakeDamage(int _damage)
    {
        _currentHealth -= _damage;
        
        if(_currentHealth <= 0)
        {

            explousion.Play();

            Destroy(gameObject);

            Instantiate(_explousionOnDeath, transform.position, transform.rotation);
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
