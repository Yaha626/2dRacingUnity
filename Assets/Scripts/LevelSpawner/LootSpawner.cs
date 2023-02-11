using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LootSpawner : MonoBehaviour
{
    public GameObject[] _LootObjects;



    private void Start()
    {
        int rand = Random.Range(0, _LootObjects.Length);

        Instantiate(_LootObjects[rand], transform.position, Quaternion.identity);
    }

    // LootSpawnPoint



}
