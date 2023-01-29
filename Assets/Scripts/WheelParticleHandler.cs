using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WheelParticleHandler : MonoBehaviour
{

    float particleEmissionRate = 0;

    CarController1Player carController1Player;

    ParticleSystem particleSystemSmoke;

    ParticleSystem.EmissionModule particleSystemEmmisionModule;



    private void Awake()
    {

        carController1Player = GetComponentInParent<CarController1Player>();

        particleSystemSmoke = GetComponent<ParticleSystem>();

        particleSystemEmmisionModule = particleSystemSmoke.emission;

        particleSystemEmmisionModule.rateOverTime = 0;

    }


    private void Update()
    {

        particleEmissionRate = Mathf.Lerp(particleEmissionRate, 0, Time.deltaTime * 5);

        particleSystemEmmisionModule.rateOverTime = particleEmissionRate;

        if (carController1Player.IsTireScretching(out float lateralVelocity, out bool isBraking))
            if (isBraking)
                particleEmissionRate = 30;
            else particleEmissionRate = Mathf.Abs(lateralVelocity * 2);
    }
}
