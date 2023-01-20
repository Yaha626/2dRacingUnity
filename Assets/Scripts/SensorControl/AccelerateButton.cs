using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AccelerateButton : MonoBehaviour
{

    CarInputHandler _carInputHandler;

    

    private void Awake()
    {
        _carInputHandler = GetComponent<CarInputHandler>();
    }

    private void OnMouseDown()
    {

        _carInputHandler._accelerateVector = 1f;

    }

    private void OnMouseUp()
    {

       

    }


}
