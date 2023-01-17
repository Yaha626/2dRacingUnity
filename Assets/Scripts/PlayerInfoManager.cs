using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using YG;

public class PlayerInfoManager : MonoBehaviour
{

    public static int _SelectedCar;

    private string _platformType;

    [SerializeField] GameObject _MobileControlMenu;

    [SerializeField] Text _PlayerDeviceFromYandex;




    private void Start()
    {
        _PlayerDeviceFromYandex.text = YandexGame.EnvironmentData.deviceType;

        _platformType = YandexGame.EnvironmentData.deviceType;

        _MobileControlMenu.SetActive(true);

       // MobileControlCanvasHider();

    }

    private void MobileControlCanvasHider()
    {
        if(_platformType == "desktop")
        {
            _MobileControlMenu.SetActive(false);
        }
    }


}
