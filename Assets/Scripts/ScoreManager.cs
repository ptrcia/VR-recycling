using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager instance;
    public Text numberText;

    public PointsBar pointsBar;
    public int maxPoints;
    public int number=0;

    private void Awake()
    {
        instance = this;
    }
    private void Start()
    {
        //number = minPoints;
        pointsBar.SetMaxPoints(maxPoints);
        numberText.text = "Garbage Recycled: " + number.ToString();
    } 
    public void AddPoint()
    {
        number += 1;
        numberText.text = "Garbage Recycled: " + number.ToString();
        pointsBar.SetPoints(number);
    }
    public void RemovePoint()
    {
        number -= 1;
        numberText.text = "Garbage Recycled: " + number.ToString();
        pointsBar.SetPoints(number);
    }
}

