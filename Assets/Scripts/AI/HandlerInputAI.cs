using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HandlerInputAI : MonoBehaviour
{

    public enum AImode { followPlayer, followWayPoints};

    [Header("AI Settings")]
    public AImode aiMode;

    Vector3 _targetPosition = Vector3.zero;

  //  Vector2 _targetWayRoad = Vector2.zero;

    Transform _targetTransform = null;

    CarController1Player _CarController;

    public GameObject _LeftTurnPoint;

    public GameObject _RightTurnPoint;

    public GameObject _StraightWay;

    public GameObject _StraightWayHome;

    // private GameObject _tmpTurnSelector;

    public LayerMask _layerMaskBorderOfRoadMainRay;

    [SerializeField] float rayMainFrontDistance;
 
   // float _actionOnDistance;

    






    private void Awake()
    {

        _CarController = GetComponent<CarController1Player>();

    }

    private void Start()
    {
       // _actionOnDistance = 0f;
    }


    private void Update()
    {

        RaycastHit2D _hitLeftSide = Physics2D.Raycast(_LeftTurnPoint.transform.position, transform.up, 10, _layerMaskBorderOfRoadMainRay);



        RaycastHit2D _hitRigytSide = Physics2D.Raycast(_RightTurnPoint.transform.position, transform.up, 10, _layerMaskBorderOfRoadMainRay);

        if(!_hitLeftSide & !_hitRigytSide)
        {
            _StraightWay.transform.position = _StraightWayHome.transform.position;
        }

        if (_hitLeftSide)
        {
            _StraightWay.transform.position = _RightTurnPoint.transform.position;
        }

        if (_hitRigytSide)
        {
            _StraightWay.transform.position = _LeftTurnPoint.transform.position;
        }
        



        Debug.DrawRay(_LeftTurnPoint.transform.position, transform.up * 10, Color.green);
        Debug.DrawRay(_RightTurnPoint.transform.position, transform.up * 10, Color.green);

        RaycastHit2D _hitObstance =   Physics2D.Raycast(transform.position, transform.up, rayMainFrontDistance, _layerMaskBorderOfRoadMainRay);


        if(_hitObstance)
        {
            Debug.Log("Ray is Detect Object");

            Debug.DrawRay(transform.position, transform.up * rayMainFrontDistance, Color.green); // this is good!

           // Destroy(_hitObstance.collider.gameObject);

        }
        else
        {
            Debug.Log("Ray is not Detect Object");

           // Debug.DrawRay(); // this is good!
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

        inputVector.y = 1f;

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

             _targetTransform = _StraightWay.transform;

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
