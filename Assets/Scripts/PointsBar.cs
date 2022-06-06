using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PointsBar : MonoBehaviour
{
    public Slider slider;
    public void SetMaxPoints(int points) { 
        slider.maxValue = points;
        slider.value = points;
    }
    public void SetPoints(int points) {
        slider.value = points; 
    }
}