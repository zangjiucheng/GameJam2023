using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Health : MonoBehaviour
{

    public Slider slider;

    public void setMaxHealth(int health){
        slider.value = health;
        slider.maxValue = health;
    }

    public void setHealth(int health){
        slider.value = health;
    }
}
