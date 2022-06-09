using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;


public class ScoreAdmin: MonoBehaviour
{
    [SerializeField] private Transform Object;
    public GameObject RightLight;
    public GameObject WrongLight;
    public GameObject NeutralLight;

    public string Tag;
    //public string Tag2;

    //public UnityEvent Right;
    //public UnityEvent Wrong;
    //public UnityEvent Neutral;


    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag(Tag)) 
        {
            ScoreManager.instance.AddPoint();
            //Right.Invoke();
            Right2();
        }
        else if (other.CompareTag("Player")){}
        else if (other.CompareTag("Untagged")){}
        else
        {
            //else if (Object.CompareTag(Tag2)==(other.CompareTag(Tag)){Neutral.Invoke();}
            ScoreManager.instance.RemovePoint();
            //Wrong.Invoke();
            Wrong2();

        }
    }

    private void Right2()
    {
        RightLight.SetActive(true);
    }
    private void Wrong2()
    {
        WrongLight.SetActive(true);
    }
    private void Neutral2()
    {
        NeutralLight.SetActive(true);
    }
}

