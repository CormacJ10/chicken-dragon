using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

//[RequireComponent]
public class BarController : MonoBehaviour
{
    [SerializeField] private Slider slider;

    private int currentValue = 100;
    private int maxValue = 100;

    public int CurrentValue
    {
        get { return currentValue; }
        set
        {
            currentValue = value;
            ValueLimiter();            
        }
    }
    public int MaxHealth
    {
        get { return maxValue; }
        set
        {
            maxValue = value;
            ValueLimiter();            
        }
    }

    public void ChangeBy(int change)
    {
        currentValue += change;
        ValueLimiter();  
    }

    private void ValueLimiter()
    {
        if (currentValue < 0)
        {
            Debug.Log("WIP - ChickenScript: what happens when value is less than 0");
        }
        else if (currentValue > maxValue) 
        { 
            currentValue = maxValue; 
        }
        slider.value = currentValue;
        slider.maxValue = maxValue;
    }
}
