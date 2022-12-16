using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class HealthBar : MonoBehaviour
{
    public Image _healthBar;

    public float _fill;

    private int _currentHealth;

    //private int _maxHealth;



    private void Start()
    {
        _fill = 1f;

    }


    private void Update()
    {
        _currentHealth = GetComponent<CarCondition>()._currentHealth;
       // _maxHealth = GetComponent<CarCondition>()._maxHealth;

        _fill = _currentHealth * 0.01f;

        if(_healthBar)
        {
            _healthBar.fillAmount = _fill;
        }
        
         
    }
}
