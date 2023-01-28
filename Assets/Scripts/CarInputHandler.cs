using System.Collections;
using System.Collections.Generic;
using UnityEngine;




public class CarInputHandler : MonoBehaviour
{

    private PlayerInput _playerInput;

    public float _accelerateVector = 0f;

    public float _turnVector = 0f;

    CarController1Player _carController1Player;



    private void Awake()
    {

        _carController1Player = GetComponent<CarController1Player>();

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


    
    private void Update()
    {

        Vector2 driveVector = _playerInput.Player1.Ride.ReadValue<Vector2>();
      
        _carController1Player.SetInputVector(driveVector);

    }

}
