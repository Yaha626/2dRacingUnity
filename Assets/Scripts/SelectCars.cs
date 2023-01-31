using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SelectCars : MonoBehaviour
{
  
    private GameObject[] _cars;

    public GameObject[] _prioraColor;
   
    public GameObject[] _musculeColor;

    private int _indexOfCar;

    public GameObject _MainMenu;

    public GameObject _SelectCarsMenu;

   // private string _currentTypeCar1P;

    private string _typeOfCar;

    private string _typeOfColor;

    private string _typeOfSkin;





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

       

        
        foreach (GameObject go in _prioraColor)
        {

            if (go.tag == _typeOfColor)
            {

                go.SetActive(true);

            }
            else
            {

                go.SetActive(false);

            }

        }

        foreach (GameObject go in _musculeColor)
        {

            if (go.tag == _typeOfColor)
            {

                go.SetActive(true);

            }
            else
            {

                go.SetActive(false);

            }

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

        _typeOfCar = _cars[_indexOfCar].tag;

        StaticInfoPlayer1._currentTypeCar1P = _typeOfCar + _typeOfColor;

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

        _typeOfCar = _cars[_indexOfCar].tag;

        StaticInfoPlayer1._currentTypeCar1P = _typeOfCar + _typeOfColor;

    }


    public void StartLevelSceen()
    {

        StaticInfoPlayer1._currentTypeCar1P = _typeOfCar + _typeOfColor;

        PlayerPrefs.SetInt("SelectCar", _indexOfCar);

        PlayerPrefs.SetString("_typeOfCar", _typeOfCar);

        PlayerPrefs.SetString("_typeOfColor", _typeOfColor);

        PlayerPrefs.SetString("_typeOfSkin", _typeOfSkin);



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



    public void SelectColorYellow()
    {
        _typeOfColor = "Yellow";

        SelectorCurrentCarSpriteAndTag();

    }


    public void SelectColorBlue()
    {

        _typeOfColor = "Blue";

        SelectorCurrentCarSpriteAndTag();

    }


    public void SelectColorGray()
    {

        _typeOfColor = "Gray";

        SelectorCurrentCarSpriteAndTag();

    }


    public void SelectColorRed()
    {

        _typeOfColor = "Red";

        SelectorCurrentCarSpriteAndTag();

    }


    public void SelectColorBlack()
    {
        _typeOfColor = "Black";

        SelectorCurrentCarSpriteAndTag();

    }



    public void SelectColorGreen()
    {

        _typeOfColor = "Green";

        SelectorCurrentCarSpriteAndTag();

    }



    private void SelectorCurrentCarSpriteAndTag()
    {
        StaticInfoPlayer1._currentTypeCar1P = _typeOfCar + _typeOfColor;

        Debug.Log(StaticInfoPlayer1._currentTypeCar1P);

        foreach (GameObject go in _prioraColor)
        {

            if (go.tag == _typeOfColor)
            {

                go.SetActive(true);

            }
            else
            {

                go.SetActive(false);

            }

        }

        foreach (GameObject go in _musculeColor)
        {

            if (go.tag == _typeOfColor)
            {

                go.SetActive(true);

            }
            else
            {

                go.SetActive(false);

            }

        }
    }


  


}
