using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using UnityEngine.UI;

public class HealthBarPositionEnemy : MonoBehaviour
{

    private Camera _cameraMain;


    void Start()
    {   
         _cameraMain = Camera.main;
    }

    private void LateUpdate()
      {
         transform.LookAt(new Vector3(transform.position.x, transform.position.y, _cameraMain.transform.position.z));
    //transform.Rotate(0, 180, 0);

     }
}
