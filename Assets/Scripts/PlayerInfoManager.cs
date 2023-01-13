using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using YG;

public class PlayerInfoManager : MonoBehaviour
{

    public static int _SelectedCar;


    [SerializeField] Text _PlayerDeviceFromYandex;




    private void Start()
    {
        _PlayerDeviceFromYandex.text = YandexGame.EnvironmentData.deviceType;
    }


}
