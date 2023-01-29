using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetInfoStartLevel : MonoBehaviour
{

    public GameObject[] Player1CarSprite;

    private string _TypeOfBodyPlayer1;

    
    void Start()
    {

        _TypeOfBodyPlayer1 = StaticInfoPlayer1._currentTypeCar1P;

        GetPlayer1TypeCar();

    }




    void GetPlayer1TypeCar()
    {

        foreach (GameObject go in Player1CarSprite)
        {

            if (go.tag == _TypeOfBodyPlayer1)
            {

               go.SetActive(true);

            }
            else
            {

                go.SetActive(false);

            }

        }

    }   


}
