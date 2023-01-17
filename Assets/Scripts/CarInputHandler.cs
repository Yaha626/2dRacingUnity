using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using YG;

public class CarInputHandler : MonoBehaviour
{

    private float _accelerate = 0f;

    private float _turn = 0f;

    public float _testTemporaryControlViever;


    CarController1Player _carController1Player;

    private string _platformType;

    private void Awake()
    {
        _carController1Player = GetComponent<CarController1Player>();

        _platformType = YandexGame.EnvironmentData.deviceType;
    }

    // "desktop"
    // "mobile"
    private void Update()
    {
        Vector2 inputVector = Vector2.zero;
        if (_platformType == "desktop")
         {
           // Vector2 inputVector = Vector2.zero;

            inputVector.x = Input.GetAxis("Horizontal");
            inputVector.y = Input.GetAxis("Vertical");

            //_testTemporaryControlViever = inputVector.x;

           // _carController1Player.SetInputVector(inputVector);

        }
        else
        {
           // Vector2 inputVector = Vector2.zero;

            inputVector.x = _turn;
            inputVector.y = _accelerate;

           // _carController1Player.SetInputVector(inputVector);
        }
        _testTemporaryControlViever = inputVector.x;

        _carController1Player.SetInputVector(inputVector);

    }

    public void AccelerateButtonDown()
    {
        _accelerate = 1f;
    }


    public void BrakeButtonDown()
    {
        _accelerate = -1f;
    }


    public void AccelerateButtonUp()
    {
        _accelerate = 0f;
    }

    public void BrakeButtonUp()
    {
        _accelerate = 0f;
    }


    public void TurnLeftButtonDown()
    {
        _turn = -1f;
    }


    public void TurnRightButtonDown()
    {
        _turn = 1f;
    }


    public void TurnLeftButtonUp()
    {
        _turn = 0f;
    }

    public void TurnRightButtonUp()
    {
        _turn = 0f;
    }

}
