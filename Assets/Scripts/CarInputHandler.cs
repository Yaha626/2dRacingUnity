using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using YG;
using UnityEngine.UI;

public class CarInputHandler : MonoBehaviour
{

    [SerializeField] GameObject _ButtonBrake;

    [SerializeField] GameObject _ButtonAccelerate;

    [SerializeField] GameObject _ButtonLeft;

    [SerializeField] GameObject _ButtonRight;

    [SerializeField] GameObject _ButtonFire;


    public float _accelerateVector = 0f;

    public float _turnVector = 0f;

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

        if (_platformType == "desktop")
        {
            Vector2 inputVector = Vector2.zero;

            inputVector.x = Input.GetAxis("Horizontal");
            inputVector.y = Input.GetAxis("Vertical");

            _carController1Player.SetInputVector(inputVector);

        }
        else
        {

            Vector2 inputVector = Vector2.zero;

            inputVector.x = _turnVector;
            inputVector.y = _accelerateVector;

            _carController1Player.SetInputVector(inputVector);

        }
    }

    public void AccelerateButtonDown()
    {
        _accelerateVector = 1f;
    }

    public void BrakeReverceButtonDown()
    {
        _accelerateVector = -1f;
    }


    public void TurnLeftButtonDown()
    {
        _turnVector = -1f;
    }

    public void TurnRightButtonDown()
    {
        _turnVector = 1f;
    }

    public void AccelerateBrakeButtonUp()
    {
        _accelerateVector = 0f;

        AntiStickingBrakeAccelerate();
    }

    public void TurnButtonUp()
    {
        _turnVector = 0f;

        AntiStickingTurn();

    }

    public void AntiStickingBrakeAccelerate()
    {
        _ButtonBrake.SetActive(false);
        _ButtonBrake.SetActive(true);
        _ButtonAccelerate.SetActive(false);
        _ButtonAccelerate.SetActive(true);

    }

    public void AntiStickingTurn()
    {
        _ButtonLeft.SetActive(false);
        _ButtonLeft.SetActive(true);
        _ButtonRight.SetActive(false);
        _ButtonRight.SetActive(true);

    }

}
