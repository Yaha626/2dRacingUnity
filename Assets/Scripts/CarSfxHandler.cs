using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
public class CarSfxHandler : MonoBehaviour
{
    [Header("SfxVolume")]
    public AudioMixer audioMixer;


    [Header("AudioSources")]
    public AudioSource tireScretchingAudioSource;   
    public AudioSource engineAudioSource;   
    public AudioSource hitAudioSource;

    float desiredEnginePich = 0.5f;
    float tireScrachPich = 0.5f;

    CarController1Player carController1Player;


    private void Awake()
    {
        carController1Player = GetComponentInParent<CarController1Player>();
    }


    void Start()
    {
        audioMixer.SetFloat("SFXVolume", 0.5f);
    }

    private void Update()
    {
        UpdateEngineSfx();
        UpdateTireScritchingSfx();
    }


    void UpdateEngineSfx()
    {
        float velocityMagnitude = carController1Player.GetVelocityMagnitude();

        float desireEngineVolume = velocityMagnitude * 0.5f;

        desireEngineVolume = Mathf.Clamp(desireEngineVolume, 0.2f, 1.0f);

        engineAudioSource.volume = Mathf.Lerp(engineAudioSource.volume, desireEngineVolume, Time.deltaTime * 10);

        desiredEnginePich = velocityMagnitude * 0.2f;
        desiredEnginePich = Mathf.Clamp(desiredEnginePich, 0.5f, 2f);
        engineAudioSource.pitch = Mathf.Lerp(engineAudioSource.pitch, desiredEnginePich, Time.deltaTime * 1.5f);

    }


    void UpdateTireScritchingSfx()
    {
        if(carController1Player.IsTireScretching(out float lateralVelocity, out bool isBraking))
        {
            if (isBraking)
            {
                tireScretchingAudioSource.volume = Mathf.Lerp(tireScretchingAudioSource.volume, 1.0f, Time.deltaTime * 10);
                tireScrachPich = Mathf.Lerp(tireScrachPich, 0.5f, Time.deltaTime * 10);
            }
            else
            {
                tireScretchingAudioSource.volume = Mathf.Abs(lateralVelocity) * 0.5f;
                tireScrachPich = Mathf.Abs(lateralVelocity) * 0.1f;
            }
        }
        else
        {
            tireScretchingAudioSource.volume = Mathf.Lerp(tireScretchingAudioSource.volume, 0, Time.deltaTime * 10);
        }

    }


    private void OnCollisionEnter2D(Collision2D collision2D)
    {
        float relativeVelocity = collision2D.relativeVelocity.magnitude;

        float volume = relativeVelocity * 0.1f;

        hitAudioSource.pitch = Random.Range(0.95f, 1.05f);
        hitAudioSource.volume = volume;

        if (!hitAudioSource.isPlaying)
        {
            hitAudioSource.Play();
        }



    }
}
