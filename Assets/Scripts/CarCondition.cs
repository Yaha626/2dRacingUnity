using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CarCondition : MonoBehaviour
{



    [SerializeField] GameObject _explousionOnDeath;

    public GameObject _carObject;



    [Header ("Health")]

    public float _maxHealth = 100f;

    public float _currentHealth = 100f;

    public AudioSource explousion;


   

    public void TakeDamage(int _damage)
    {
        _currentHealth -= _damage;
        
        if(_currentHealth <= 0)
        {

          //  explousion.Play();

            DisabledCarOnDeath();

            Instantiate(_explousionOnDeath, transform.position, transform.rotation);

            Invoke("EnabledCarOnDeath", 5f);
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


    public void DisabledCarOnDeath()
    {
        _carObject.SetActive(false);
    }


    public void EnabledCarOnDeath()
    {
        _carObject.SetActive(true);

        _currentHealth = _maxHealth;




    }
}
