using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class HealthBar : MonoBehaviour
{
    [SerializeField] private Image _healthBar;

    [SerializeField] private Gradient _gradient;

    private float _currentHealth;

    private float _maxHealth;

    private float _valueOfCurrentCondition;

    private void Start()
    {
        
        _healthBar.fillAmount = 1f;

        _healthBar.color = _gradient.Evaluate(1f);
       
    }


    private void Update()
    {
        _currentHealth = GetComponent<CarCondition>()._currentHealth;
       
        _maxHealth = GetComponent<CarCondition>()._maxHealth;

        _valueOfCurrentCondition = _currentHealth / _maxHealth;


        if (_healthBar)
        {
            _healthBar.fillAmount = _valueOfCurrentCondition;

            _healthBar.color = _gradient.Evaluate(_valueOfCurrentCondition);
        }
               
    }

}
