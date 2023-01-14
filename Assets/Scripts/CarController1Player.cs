using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarController1Player : MonoBehaviour
{
    
    [Header("CarSettings")]
    public float _driftFactor = 0.95f;
    public float _accelerationFactor = 30.0f;
    public float _turnFactor = 3.5f;
    public float _maxSpeed = 20f;

    float _accelerationInput = 0;
    float _turnInput = 0;

    float _rotationAngle = 0;

    float _velocityVsUp = 0;



    Rigidbody2D _carRigidBody2d;




    private void Awake()
    {
        _carRigidBody2d = GetComponent<Rigidbody2D>();
    }

    public float GetVelocityMagnitude()
    {
        return _carRigidBody2d.velocity.magnitude;
    }

    private void FixedUpdate()
    {
        ApplyEngineForce();

        KillOrthogonalVelosity();

        ApplySteereng();
    }

    void ApplyEngineForce()
    {
        _velocityVsUp = Vector2.Dot(transform.up, _carRigidBody2d.velocity);

        if (_velocityVsUp > _maxSpeed && _accelerationInput > 0)
            return;

        if (_velocityVsUp < -_maxSpeed * 0.5f && _accelerationInput < 0)
            return;

        if (_carRigidBody2d.velocity.sqrMagnitude > _maxSpeed * _maxSpeed && _accelerationInput > 0)
            return;

        if (_accelerationInput == 0)
        {
            _carRigidBody2d.drag = Mathf.Lerp(_carRigidBody2d.drag, 3.0f, Time.fixedDeltaTime * 3);
        }
        else
        {
            _carRigidBody2d.drag = 0;
        }

        Vector2 _engineForceVector = transform.up * _accelerationInput * _accelerationFactor;

        _carRigidBody2d.AddForce(_engineForceVector, ForceMode2D.Force);
    }

    void ApplySteereng()
    {
        float _minSpeedBeforeAllowTurningFactor = (_carRigidBody2d.velocity.magnitude / 8);
        _minSpeedBeforeAllowTurningFactor = Mathf.Clamp01(_minSpeedBeforeAllowTurningFactor);

        _rotationAngle -= _turnInput * _turnFactor * _minSpeedBeforeAllowTurningFactor;

        _carRigidBody2d.MoveRotation(_rotationAngle);
    }

    void KillOrthogonalVelosity()
    {
        Vector2 forwardVelocity = transform.up * Vector2.Dot(_carRigidBody2d.velocity, transform.up);
        Vector2 rightVelocity = transform.right * Vector2.Dot(_carRigidBody2d.velocity, transform.right);

        _carRigidBody2d.velocity = forwardVelocity + rightVelocity * _driftFactor;
    }


    float GetLateralVelocity()
    {
        return Vector2.Dot(transform.right, _carRigidBody2d.velocity);
    }

    public bool IsTireScretching(out float lateralVelocity, out bool isBraking)
    {
        lateralVelocity = GetLateralVelocity();
        isBraking = false;

        if(_accelerationInput < 0 && _velocityVsUp > 0)
        {
            isBraking = true;
            return true;
        }

        if (Mathf.Abs(GetLateralVelocity()) > 4.0f)
            return true;

        return false;
    }
    public void SetInputVector(Vector2 inputVector)
    {
        _turnInput = inputVector.x;
        _accelerationInput = inputVector.y;
    }

}
