using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BrakeButton : MonoBehaviour
{

    public GameObject objectCarInputHandler;

    CarInputHandler _carInputHandler;



    private void Awake()
    {

        _carInputHandler = objectCarInputHandler.GetComponent<CarInputHandler>();
    }

    private void OnMouseDown()
    {

        _carInputHandler._accelerateVector = -1f;

    }

    private void OnMouseUp()
    {

        _carInputHandler._accelerateVector = 0f;

    }
}
