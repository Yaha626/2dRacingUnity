using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetInfoStartLevel : MonoBehaviour
{
    [SerializeField] GameObject _Car1;

    [SerializeField] GameObject _Car2;

    [SerializeField] GameObject _Car3;

    private int _currentCar;

    
    void Start()
    {
        _currentCar = PlayerInfoManager._SelectedCar;

        if(_currentCar == 0)
        {
            _Car1.SetActive(true);
        }

        Debug.Log(_currentCar);
    }

   
}
