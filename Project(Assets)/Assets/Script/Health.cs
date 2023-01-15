using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Health : MonoBehaviour
{

    public Slider slider;
    public Gradient gradient;
    public Image fill;

    public void setMaxHealth(int health){
        slider.value = health;
        slider.maxValue = health;

        fill.color = gradient.Evaluate(1f);
    }

    public void setHealth(int health){
        slider.value = health;

        fill.color = gradient.Evaluate(slider.normalizedValue);
    }
}
