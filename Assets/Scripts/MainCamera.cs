using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainCamera : MonoBehaviour
{
    private void LateUpdate()
    {

        transform.LookAt(new Vector3(transform.position.x, transform.position.y, 0));
      
    }
}
