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

    public GameObject _rayMainFront;

    public GameObject _rayMainFrontPointDirection;

    [SerializeField] float rayMainFrontDistance;
 
    float _actionOnDistance;






    private void Awake()
    {

        _CarController = GetComponent<CarController1Player>();

    }

    private void Start()
    {
        _actionOnDistance = 0f;
    }


    private void Update()
    {

      RaycastHit2D _hitObstance =   Physics2D.Raycast(_rayMainFront.transform.position, Vector2.up , rayMainFrontDistance);

        if(_hitObstance.collider != null)
        {
            Debug.Log("Ray is Detect Object");
            Debug.DrawRay(transform.position, transform.up * rayMainFrontDistance, Color.green); // this is good!

           // Debug.DrawRay(_rayMainFront.transform.position, Vector2.up, rayMainFrontDistance, Color.yellow);

        }
        else
        {
            Debug.Log("Ray is not Detect Object");
            Debug.DrawRay(_rayMainFront.transform.position, _rayMainFrontPointDirection.transform.position, Color.red);
        }

    }

    private void LateUpdate()
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

        inputVector.y = 0.05f;

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

         //   _targetTransform = _wayCorrector.transform;

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

}
