using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SelectCars : MonoBehaviour
{
  
    private GameObject[] _cars;

    private int _indexOfCar;

    public GameObject _MainMenu;

    public GameObject _SelectCarsMenu;

    private string _currentTypeCar1P;




    private void Start()
    {

        _indexOfCar = PlayerPrefs.GetInt("SelectCar");

        _cars = new GameObject[transform.childCount];

        for(int i = 0; i < transform.childCount; i++)
        {
            _cars[i] = transform.GetChild(i).gameObject;    
        }

        foreach(GameObject go in _cars)
        {
            go.SetActive(false);
        }

        if (_cars[_indexOfCar])
        {
            _cars[_indexOfCar].SetActive(true);
        }

    }

    public void SelectLeft()
    {

        _cars[_indexOfCar].SetActive(false);

        _indexOfCar--;

        if(_indexOfCar < 0)
        {
            _indexOfCar = _cars.Length - 1;
        }

        _cars[_indexOfCar].SetActive(true);

        _currentTypeCar1P = _cars[_indexOfCar].tag;

        StaticInfoPlayer1._currentTypeCar1P = _currentTypeCar1P;

        Debug.Log(StaticInfoPlayer1._currentTypeCar1P);



    }


    public void SelectRight()
    {

        _cars[_indexOfCar].SetActive(false);

        _indexOfCar++;

        if (_indexOfCar == _cars.Length)
        {
            _indexOfCar = 0;
        }

        _cars[_indexOfCar].SetActive(true);

        _currentTypeCar1P = _cars[_indexOfCar].tag;

        StaticInfoPlayer1._currentTypeCar1P = _currentTypeCar1P;

        Debug.Log(StaticInfoPlayer1._currentTypeCar1P);

    }


    public void StartLevelSceen()
    {

        StaticInfoPlayer1._currentTypeCar1P = _currentTypeCar1P;

        PlayerPrefs.SetInt("SelectCar", _indexOfCar);

        PlayerInfoManager._SelectedCar = _indexOfCar;

        SceneManager.LoadScene("Lavel_1_1");

    }


    public void SelectMainMenu()
    {

        _MainMenu.SetActive(true);

        _SelectCarsMenu.SetActive(false);

    }


    public void MenuSelectCars()
    {

        _MainMenu.SetActive(false);

        _SelectCarsMenu.SetActive(true);



    }
}
