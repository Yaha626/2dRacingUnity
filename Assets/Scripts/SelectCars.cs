using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SelectCars : MonoBehaviour
{
  
    public GameObject[] _carBodyType;

    public GameObject[] _prioraColor;
   
    public GameObject[] _musculeColor;

    public GameObject _MainMenu;

    public GameObject _SelectCarsMenu;

    private string _typeOfCar;

    private string _typeOfColor;

    private string _typeOfSkin;

    public GameObject _skinScrollMenu;

    public GameObject _carScrollMenu;

    public TextMeshProUGUI _TextSelectorCarScin;





    private void Start()
    {
        _typeOfCar = StaticInfoPlayer1._currentTypeBodyCar;

        _typeOfColor = StaticInfoPlayer1._currentTypeColorCar;

        _typeOfSkin = StaticInfoPlayer1._currentTypeSkinCar;



        PlayerPrefs.GetString("_typeOfCar", _typeOfCar);

        PlayerPrefs.GetString("_typeOfColor", _typeOfColor);

        PlayerPrefs.GetString("_typeOfSkin", _typeOfSkin);



        foreach (GameObject go in _carBodyType)
        {

            if (go.tag == _typeOfCar)
            {

                go.SetActive(true);

            }
            else
            {

                go.SetActive(false);

            }

        }

        PrioraColorSelector();

        MusculeColorSelector();

    }



    public void SelectMusculeBody()
    {

        _typeOfCar = "Muscule";

        foreach (GameObject go in _carBodyType)
        {

            if (go.tag == _typeOfCar)
            {

                go.SetActive(true);

            }
            else
            {

                go.SetActive(false);

            }

        }
    }

    public void SelectPrioraBody()
    {

        _typeOfCar = "Priora";

        foreach (GameObject go in _carBodyType)
        {

            if (go.tag == _typeOfCar)
            {

                go.SetActive(true);

            }
            else
            {

                go.SetActive(false);

            }

        }



    }


    public void StartLevelSceen()
    {


        StaticInfoPlayer1._currentTypeCar1P = _typeOfCar + _typeOfColor;

        StaticInfoPlayer1._currentTypeBodyCar = _typeOfCar;

        StaticInfoPlayer1._currentTypeColorCar = _typeOfColor;

        StaticInfoPlayer1._currentTypeSkinCar = _typeOfSkin;

        // PlayerPrefs.SetInt("SelectCar", _indexOfCar);

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



    public void PrioraColorSelector()
    {

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

    }


    public void MusculeColorSelector()
    {

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



    private void SelectorCurrentCarSpriteAndTag()
    {
        StaticInfoPlayer1._currentTypeCar1P = _typeOfCar + _typeOfColor;

        Debug.Log(StaticInfoPlayer1._currentTypeCar1P);

        PrioraColorSelector();

        MusculeColorSelector();

    }


    public void CarSkinSelectorBotton()
    {

        if (_TextSelectorCarScin.text == "Тачка")
        {
            _carScrollMenu.SetActive(true);

            _skinScrollMenu.SetActive(false);

            _TextSelectorCarScin.text = "Скин";

        }
        else
        {
            _skinScrollMenu.SetActive(true);

            _carScrollMenu.SetActive(false);

            _TextSelectorCarScin.text = "Тачка";
        }

    }

}
