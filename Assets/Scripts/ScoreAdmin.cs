using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;


public class ScoreAdmin: MonoBehaviour
{
    [SerializeField] private Transform Object;
    //[SerializeField] private Transform respawnPointObj;
    public string Tag;

    public UnityEvent Right;
    public UnityEvent Wrong;
    public UnityEvent Neutral;

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag(Tag)) 
        {
            ScoreManager.instance.AddPoint();
            Right.Invoke();
        }
        else if (other.CompareTag("Player")){}
        else
        {
            ScoreManager.instance.RemovePoint();
            Wrong.Invoke();
        }    
    }
}

