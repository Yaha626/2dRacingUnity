using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarInputHandler : MonoBehaviour
{
    CarController1Player _carController1Player;

    private void Awake()
    {
        _carController1Player = GetComponent<CarController1Player>();
    }


    private void Update()
    {
        Vector2 inputVector = Vector2.zero;

        inputVector.x = Input.GetAxis("Horizontal");
        inputVector.y = Input.GetAxis("Vertical");

        _carController1Player.SetInputVector(inputVector);

    }
}
