using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using YG;
//using UnityEngine.InputSystem;



public class CarInputHandler : MonoBehaviour
{

    private PlayerInput _playerInput;

    public float _accelerateVector = 0f;

    public float _turnVector = 0f;

    CarController1Player _carController1Player;

  //  private string _platformType;

    private void Awake()
    {

        _carController1Player = GetComponent<CarController1Player>();

       // _platformType = YandexGame.EnvironmentData.deviceType;

        _playerInput = new PlayerInput();

    }



    private void OnEnable()
    {
        _playerInput.Enable();
    }



    private void OnDisable()
    {
        _playerInput.Disable();
    }

    // "desktop"
    // "mobile"


    
    private void Update()
    {

        Vector2 driveVector = _playerInput.Player1.Ride.ReadValue<Vector2>();
      
        _carController1Player.SetInputVector(driveVector);


        /*     if (_platformType == "desktop")
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
        */
    }

}
