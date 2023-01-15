using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class player : MonoBehaviour
{

    public int maxHealth = 60;
    public int currentHealth;
    public Health healthBar;

    private float timeDelay = 1f;
    private float action = 0f;

    void Start()
    {
        currentHealth = maxHealth;
        healthBar.setMaxHealth(maxHealth);
        action = Time.time + timeDelay;
    }

    void Update()
    {
        if (action <= Time.time)
        {
            takeDamage(1);
            action = Time.time + timeDelay;
        }
        if (currentHealth <= 0)
        {
            SceneManager.LoadScene(4);
        }
    }

    public void takeDamage(int damage)
    {
        currentHealth -= damage;
        healthBar.setHealth(currentHealth);
    }
}
