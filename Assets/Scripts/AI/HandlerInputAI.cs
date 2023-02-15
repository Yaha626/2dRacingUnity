using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HandlerInputAI : MonoBehaviour
{

    public enum AImode { followPlayer, followWayPoints};

    [Header("AI Settings")]
    public AImode aiMode;

    Vector3 _targetPosition = Vector3.zero;

    Transform _targetTransform = null;

    CarController1Player _CarController;

    private float _wayPointSelectorCounter = 1;


    private void Awake()
    {

        _CarController = GetComponent<CarController1Player>();


    }



    private void FixedUpdate()
    {

        Vector2 inputVector = Vector2.zero;
        
        switch (aiMode)
        {
            case AImode.followPlayer:
                FollowPlayer();
                break;

            case AImode.followWayPoints:
                FollowWayPoints();
                break;


        }

        inputVector.x = TurnTowardTarget();

        inputVector.y = 0.3f;

        _CarController.SetInputVector(inputVector);

    }



    private void FollowPlayer()
    {
        if(_targetTransform == null)
        {
            _targetTransform = GameObject.FindGameObjectWithTag("Player").transform;
        }

        if (_targetTransform != null)
        {
            _targetPosition = _targetTransform.position;
        }


    }

   private void FollowWayPoints()
    {

        if (_targetTransform == null)
        {
            _targetTransform = GameObject.FindGameObjectWithTag("wayPoint" + _wayPointSelectorCounter.ToString()).transform;

        }

        if (_targetTransform != null)
        {
            _targetPosition = _targetTransform.position;
        }


    }


    float TurnTowardTarget()
    {

        Vector2 vectorToTarget = _targetPosition - transform.position;

        vectorToTarget.Normalize();

        float angleToTarget = Vector2.SignedAngle(transform.up, vectorToTarget);

        angleToTarget *= -1;

        float steerAmount = angleToTarget / 45.0f;

        steerAmount = Mathf.Clamp(steerAmount, -1.0f, 1.0f);
        
        return steerAmount;
    }


    private void OnCollisionEnter2D(Collision2D collision)
    {

        if (collision.gameObject.tag == "checkPoint")
        {
            _wayPointSelectorCounter += 1;
        }

    }


}
