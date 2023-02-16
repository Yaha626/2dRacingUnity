
using UnityEngine;



public class RoadSpawner : MonoBehaviour
{
    private GameObject _canvasParent;

    
    public GameObject _downUp_1;

    public GameObject _downLeft_2;

    public GameObject _downRight_3;

    public GameObject _l_LeftRight_4;

    public GameObject _r_LeftRightt_5;

    public GameObject _upRigh_6;
   
    public GameObject _upLeft_7;


    public GameObject _spawnPoint;


    private float _x = 0f;

    private float _y = 0f;

    private float _z = 1f;



    private void Start()
    {

        StaticInfoPlayer1._initedRoadPartsCounter =1;

        _canvasParent = GameObject.FindGameObjectWithTag("CanvasBackground");

       Invoke("SpawnUpElement", 0.1f);


    }





    private void SpawnUpElement()
    {
        if (StaticInfoPlayer1._initedRoadPartsCounter < StaticInfoPlayer1._maxRoadParts) 
        {

            var  _rand = Random.Range(0, 3);

            _y += 36f;

            if (_rand == 0)
            {

                var tmp = Instantiate(_downUp_1, new Vector3(_x, _y, _z), Quaternion.identity);

                var _wayPoint = GameObject.FindGameObjectWithTag("wayPointNull");

                _wayPoint.tag = "wayPoint" + StaticInfoPlayer1._initedRoadPartsCounter.ToString();

                tmp.transform.parent = _canvasParent.transform;

              

                Invoke("SpawnUpElement", 0.1f);

            }

            if (_rand == 1)
            {

                var tmp = Instantiate(_downLeft_2, new Vector3(_x, _y, _z), Quaternion.identity);

                var _wayPoint = GameObject.FindGameObjectWithTag("wayPointNull");

                _wayPoint.tag = "wayPoint" + StaticInfoPlayer1._initedRoadPartsCounter.ToString();

                tmp.transform.parent = _canvasParent.transform;



                Invoke("SpawnLeftElement", 0.1f);

            }

            if (_rand == 2)
            {

                var tmp = Instantiate(_downRight_3, new Vector3(_x, _y, _z), Quaternion.identity);

                var _wayPoint = GameObject.FindGameObjectWithTag("wayPointNull");

                _wayPoint.tag = "wayPoint" + StaticInfoPlayer1._initedRoadPartsCounter.ToString();

                tmp.transform.parent = _canvasParent.transform;



                Invoke("SpawnRighttElement", 0.1f);

            }

            StaticInfoPlayer1._initedRoadPartsCounter++;

            Debug.Log(StaticInfoPlayer1._initedRoadPartsCounter);

        }
    }

    public void SpawnLeftElement()
    {

        var _rand1 = Random.Range(0, 2);

        _x -= 36f;

        if (StaticInfoPlayer1._initedRoadPartsCounter < StaticInfoPlayer1._maxRoadParts)
        {

            if (_rand1 == 0)
            {

                var tmp = Instantiate(_r_LeftRightt_5, new Vector3(_x, _y, _z), Quaternion.identity);

                var _wayPoint = GameObject.FindGameObjectWithTag("wayPointNull");

                _wayPoint.tag = "wayPoint" + StaticInfoPlayer1._initedRoadPartsCounter.ToString();

                tmp.transform.parent = _canvasParent.transform;



                Invoke("SpawnLeftElement", 0.1f);

            }

            if (_rand1 == 1)
            {

                var tmp = Instantiate(_upRigh_6, new Vector3(_x, _y, _z), Quaternion.identity);

                var _wayPoint = GameObject.FindGameObjectWithTag("wayPointNull");

                _wayPoint.tag = "wayPoint" + StaticInfoPlayer1._initedRoadPartsCounter.ToString();

                tmp.transform.parent = _canvasParent.transform;



                Invoke("SpawnUpElement", 0.1f);

            }

        }

        StaticInfoPlayer1._initedRoadPartsCounter++;

        Debug.Log(StaticInfoPlayer1._initedRoadPartsCounter);

    }


    public void SpawnRighttElement()
    {

        var  _rand2 = Random.Range(0, 2);

        _x += 36f;

        if (StaticInfoPlayer1._initedRoadPartsCounter < StaticInfoPlayer1._maxRoadParts)
        {

            if (_rand2 == 0)
            {

                var tmp = Instantiate(_l_LeftRight_4, new Vector3(_x, _y, _z), Quaternion.identity);

                var _wayPoint = GameObject.FindGameObjectWithTag("wayPointNull");

                _wayPoint.tag = "wayPoint" + StaticInfoPlayer1._initedRoadPartsCounter.ToString();

                tmp.transform.parent = _canvasParent.transform;



                Invoke("SpawnRighttElement", 0.1f);

            }

            if (_rand2 == 1)
            {

                var tmp = Instantiate(_upLeft_7, new Vector3(_x, _y, _z), Quaternion.identity);

                var _wayPoint = GameObject.FindGameObjectWithTag("wayPointNull");

                _wayPoint.tag = "wayPoint" + StaticInfoPlayer1._initedRoadPartsCounter.ToString();

                tmp.transform.parent = _canvasParent.transform;



                Invoke("SpawnUpElement", 0.1f);

            }

        }

        StaticInfoPlayer1._initedRoadPartsCounter++;

        Debug.Log(StaticInfoPlayer1._initedRoadPartsCounter);

    }

}
