using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using YG;

public class CarInputHandler : MonoBehaviour
{

    private float _accelerate = 0f;

    private float _brakeReverce = 0f;

    private float _turnLeft = 0f;

    private float _turnRight = 0f;

    CarController1Player _carController1Player;

    private string _platformType;

    private void Awake()
    {
        _carController1Player = GetComponent<CarController1Player>();

        _platformType = YandexGame.EnvironmentData.deviceType;
    }


    private void Update()
    {
        if(_platformType == "desktop")
        {
            Vector2 inputVector = Vector2.zero;

            inputVector.x = Input.GetAxis("Horizontal");
            inputVector.y = Input.GetAxis("Vertical");

            _carController1Player.SetInputVector(inputVector);
        }
        else
        {
            Vector2 inputVector = Vector2.zero;

            inputVector.x = _accelerate;
           // inputVector.y = ;

            _carController1Player.SetInputVector(inputVector);
        }


    }

    public void AccelerateButtonDown()
    {
        _accelerate = 1f;
    }


    public void AccelerateButtonUp()
    {
        _accelerate = 0f;
    }

}
