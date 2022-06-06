using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;


public class RespawnObject : MonoBehaviour
{
    [SerializeField] private Transform Object;
    [SerializeField] private Transform respawnPointObj;
    public string Tag;


    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag(Tag)) 
        {
            Object.transform.position = respawnPointObj.transform.position;
            Object.transform.rotation = respawnPointObj.transform.rotation;

        }else if (other.CompareTag("Player")){}
        else
        {
            Object.transform.position = respawnPointObj.transform.position;
            Object.transform.rotation = respawnPointObj.transform.rotation;
        }
    }
}

