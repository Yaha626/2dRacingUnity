using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class HealthBar : MonoBehaviour
{
    public Image _healthBar;

    public float _fill;

    private int _health;



    private void Start()
    {
        _fill = 1f;

    }


    private void Update()
    {
        _health = GetComponent<CarCondition>()._currentHealth;

        _fill = _health * 0.01f;

        if(_healthBar)
        {
            _healthBar.fillAmount = _fill;
        }
        
         
    }
}
