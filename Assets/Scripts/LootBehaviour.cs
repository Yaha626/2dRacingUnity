using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LootBehaviour : MonoBehaviour
{

    public AudioSource getAudioEffect;

    public GameObject _lootItem;



    public void OnTriggerEnter2D(Collider2D collision)
    {
 
        if(collision.gameObject.tag == "Player")
        {

            SetDisabledLoot();

           // getAudioEffect.Play();

            Invoke("SetActiveLoot", 2f);

        }
            
    }


    public void SetActiveLoot()
    {

        _lootItem.SetActive(true);

    }


    public void SetDisabledLoot()
    {

        _lootItem.SetActive(false);

    }

}
