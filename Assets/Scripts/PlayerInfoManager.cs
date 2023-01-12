using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using YG;

public class PlayerInfoManager : MonoBehaviour
{

    public static int _SelectedCar;

    [SerializeField] Text _PlayerNameFromYandex;
    
    [SerializeField] ImageLoadYG _PlayerIconFromYandex;

    [SerializeField] Text _PlayerDeviceFromYandex;

    private void OnEnable() => YandexGame.GetDataEvent += DebugData;
    private void OnDisable() => YandexGame.GetDataEvent -= DebugData;



    private void Start()
    {
        if (YandexGame.SDKEnabled)
        {
            DebugData();
        }
    }

    public void  DebugData()
    {
        if (_PlayerIconFromYandex != null && YandexGame.auth)
            _PlayerIconFromYandex.Load(YandexGame.playerPhoto);

        _PlayerDeviceFromYandex.text = "domain - " + YandexGame.EnvironmentData.domain +
              "\ndeviceType - " + YandexGame.EnvironmentData.deviceType +
              "\nisMobile - " + YandexGame.EnvironmentData.isMobile +
              "\nisDesktop - " + YandexGame.EnvironmentData.isDesktop +
              "\nisTablet - " + YandexGame.EnvironmentData.isTablet +
              "\nisTV - " + YandexGame.EnvironmentData.isTV +
              "\nisTablet - " + YandexGame.EnvironmentData.isTablet +
              "\nappID - " + YandexGame.EnvironmentData.appID +
              "\nbrowserLang - " + YandexGame.EnvironmentData.browserLang +
              "\npayload - " + YandexGame.EnvironmentData.payload +
              "\npromptCanShow - " + YandexGame.EnvironmentData.promptCanShow +
              "\nreviewCanShow - " + YandexGame.EnvironmentData.reviewCanShow;

        string playerId = YandexGame.playerId;
        if (playerId.Length > 7)
            playerId = playerId.Remove(7) + "...";

        _PlayerNameFromYandex.text = "playerName - " + YandexGame.playerName +
               "\nplayerId - " + playerId +
               "\nauth - " + YandexGame.auth +
               "\nSDKEnabled - " + YandexGame.SDKEnabled +
               "\ninitializedLB - " + YandexGame.initializedLB +
               "\nphotoSize - " + YandexGame.photoSize;
    }

}
