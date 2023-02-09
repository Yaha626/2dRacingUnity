
using UnityEngine;

public class RoadSpawner : MonoBehaviour
{
    private GameObject _canvasParent;

    public Direction direction;

    public enum Direction
    {

        Top,

        Left,

        Right

    }

    private RoadParts _variants;

    private GameObject _variantsSpawnPoint;

    private int _rand;

    private float _waitTime = 3f;

    public int _maxRoadParts = 5;



    private void Start()
    {

        _canvasParent = GameObject.FindGameObjectWithTag("CanvasBackground");

        _variants = GameObject.FindGameObjectWithTag("RoadParts").GetComponent<RoadParts>();

        Destroy(gameObject, _waitTime);

        Invoke("SpawnRoad", 1f);      

    }





    public void SpawnRoad()
    {    

        if (direction == Direction.Top && StaticInfoPlayer1._initedRoadPartsCounter < _maxRoadParts)
        {            
           
            _rand = Random.Range(0, _variants._topRoad.Length);

            var tmp = Instantiate(_variants._topRoad[_rand], transform.position, _variants._topRoad[_rand].transform.rotation);

            tmp.transform.parent = _canvasParent.transform;

            tmp.transform.localScale = Vector3.one;

            StaticInfoPlayer1._initedRoadPartsCounter++;

            Debug.Log(StaticInfoPlayer1._initedRoadPartsCounter);

        }
        else if (direction == Direction.Right && StaticInfoPlayer1._initedRoadPartsCounter < _maxRoadParts)
        {
           

            _rand = Random.Range(0, _variants._rightRoad.Length);

            var tmp = Instantiate(_variants._rightRoad[_rand], transform.position, _variants._rightRoad[_rand].transform.rotation);

            tmp.transform.parent = _canvasParent.transform;

            tmp.transform.localScale = Vector3.one;

            StaticInfoPlayer1._initedRoadPartsCounter++;

            Debug.Log(StaticInfoPlayer1._initedRoadPartsCounter);

        }

        else if (direction == Direction.Left && StaticInfoPlayer1._initedRoadPartsCounter < _maxRoadParts)
        {
           

            _rand = Random.Range(0, _variants._leftRoad.Length);

            var tmp = Instantiate(_variants._leftRoad[_rand], transform.position, _variants._leftRoad[_rand].transform.rotation);

            tmp.transform.parent = _canvasParent.transform;

            tmp.transform.localScale = Vector3.one;

            StaticInfoPlayer1._initedRoadPartsCounter++;

            Debug.Log(StaticInfoPlayer1._initedRoadPartsCounter);        

        }

    }



    /*
        public void SpawnRoad()
        {

            if (!_spawned)
            {
                if (_initedRoadPartsCounter < _maxRoadParts)
                {


                    if (direction == Direction.Top)
                    {

                        _rand = Random.Range(0, _variants._topRoad.Length);

                        var tmp = Instantiate(_variants._topRoad[_rand], transform.position, _variants._topRoad[_rand].transform.rotation);

                        tmp.transform.parent = _canvasParent.transform;

                        tmp.transform.localScale = Vector3.one;



                    }
                    else if (direction == Direction.Right)
                    {

                        _rand = Random.Range(0, _variants._rightRoad.Length);

                        var tmp = Instantiate(_variants._rightRoad[_rand], transform.position, _variants._rightRoad[_rand].transform.rotation);

                        tmp.transform.parent = _canvasParent.transform;

                        tmp.transform.localScale = Vector3.one;



                    }
                    else if (direction == Direction.Bottom)
                    {

                        _rand = Random.Range(0, _variants._downRoad.Length);

                        var tmp = Instantiate(_variants._downRoad[_rand], transform.position, _variants._downRoad[_rand].transform.rotation);

                        tmp.transform.parent = _canvasParent.transform;

                        tmp.transform.localScale = Vector3.one;



                    }
                    else if (direction == Direction.Left)
                    {

                        _rand = Random.Range(0, _variants._leftRoad.Length);

                        var tmp = Instantiate(_variants._leftRoad[_rand], transform.position, _variants._leftRoad[_rand].transform.rotation);

                        tmp.transform.parent = _canvasParent.transform;

                        tmp.transform.localScale = Vector3.one;



                    }

                    _spawned = true;



                    Debug.Log(_initedRoadPartsCounter);



                }
            }

        }

    */
    public void OnTriggerStay2D(Collider2D other)
    {

      //  if (other.CompareTag("RoadParts") && other.GetComponent<RoadSpawner>()._spawned)
     //   {

     //       Destroy(gameObject);

    //    }

    }


}
