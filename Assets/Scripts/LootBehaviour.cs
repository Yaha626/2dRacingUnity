using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LootBehaviour : MonoBehaviour
{

    public AudioSource getAudioEffect;

    public GameObject _lootItem;

    public void OnTriggerEnter2D(Collider2D collision)
    {

       Debug.Log(collision.gameObject.tag);

 
        if(collision.gameObject.tag == "Player")
        {

            _lootItem.SetActive(false);

            getAudioEffect.Play();

        }
            
    }

}
