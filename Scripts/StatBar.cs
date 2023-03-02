using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StatBar : MonoBehaviour
{
    public Slider slider;
   
  
    public void SetMaxStrength(int strength)
    {
        slider.maxValue = strength;
        slider.value = strength;
    }
    public void SetMaxSleepy(int sleepy)
    {
        slider.maxValue = sleepy;
        slider.value = sleepy;
    }
    public void SetMaxAgility(int agility)
    {
        slider.maxValue = agility;
        slider.value = agility;
    }
  
   
    public void SetStrength(int strength)
    {
        slider.value = strength;
    }
    public void SetSleepy(int sleepy)
    {
        slider.value = sleepy;
    }
    public void SetAgility(int agility)
    {
        slider.value = agility;
    }
  
    

}
