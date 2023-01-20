using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootButton : MonoBehaviour
{

    public GameObject objectCarShoot;



    Shooting shooting;



    private void Awake()
    {

        shooting = objectCarShoot.GetComponent<Shooting>();
    }

    private void OnMouseDown()
    {

        shooting._shootButton = true;

    }

    private void OnMouseUp()
    {

        shooting._shootButton = false;

    }

}
