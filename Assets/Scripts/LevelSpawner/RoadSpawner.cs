
using UnityEngine;

public class RoadSpawner : MonoBehaviour
{

    public Direction direction;

    public enum Direction
    {

        Top,

        Bottom,

        Left,

        Right

    }

    private RoadParts _variants;

    private int _rand;

    private bool _spawned = false;

    private float _waitTime = 3f;



    private void Start()
    {

        _variants = GameObject.FindGameObjectWithTag("RoadParts").GetComponent<RoadParts>();

        Destroy(gameObject, _waitTime);

        Invoke("SpawnRoad", 0.2f);

    }


    public void SpawnRoad()
    {

        if (!_spawned)
        {

            if (direction == Direction.Top)
            {

                _rand = Random.Range(0, _variants._topRoad.Length);

                Instantiate(_variants._topRoad[_rand], transform.position, _variants._topRoad[_rand].transform.rotation);

            }
            else if (direction == Direction.Right)
            {

                _rand = Random.Range(0, _variants._rightRoad.Length);

                Instantiate(_variants._rightRoad[_rand], transform.position, _variants._rightRoad[_rand].transform.rotation);

            }
            else if (direction == Direction.Bottom)
            {

                _rand = Random.Range(0, _variants._downRoad.Length);

                Instantiate(_variants._downRoad[_rand], transform.position, _variants._downRoad[_rand].transform.rotation);

            }else if (direction == Direction.Left)
            {

                _rand = Random.Range(0, _variants._leftRoad.Length);

                Instantiate(_variants._leftRoad[_rand], transform.position, _variants._leftRoad[_rand].transform.rotation);

            }

            _spawned = true;

        }

    }


    public void OnTriggerStay2D(Collider2D other)
    {

        if (other.CompareTag("RoadParts") && other.GetComponent<RoadSpawner>()._spawned) ;
        {

            Destroy(gameObject);

        }

    }


}
