using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WheelTrailHandlerRander : MonoBehaviour
{

    CarController1Player carController1Player;

    TrailRenderer trailRenderer;

    private void Awake()
    {
        carController1Player = GetComponentInParent<CarController1Player>();

        trailRenderer = GetComponentInParent<TrailRenderer>();

        trailRenderer.emitting = false;
    }

    private void Update()
    {

        if (carController1Player.IsTireScretching(out float lateralVelocity, out bool isBraking))
        {

            trailRenderer.emitting = true;

        }
        else
        {

            trailRenderer.emitting = false;

        }

    }

           

        
}
