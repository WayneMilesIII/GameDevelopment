using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    public float CurrentHealth { get; set; }
    public float MaxHealth { get; set; }

    public Slider slider;
    public Player player;

    public void SetMaxHealth(int health)
    {
        slider.maxValue = health;
        slider.value = health;
    }

    public void SetHealth(int health)
    {
        slider.value = health;
    }

    void Start()
    {
        MaxHealth = 20f;

        CurrentHealth = MaxHealth;

        slider.value = CalculateHealth();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.X))
        {
            DealDamage(10);
        }
    }

    void DealDamage(float damageValue)
    {
        CurrentHealth -= damageValue;

        if (CurrentHealth <= 0)
            Die();
    }

    float CalculateHealth()
    {
        return CurrentHealth / MaxHealth;
    }

    void Die()
    {
        CurrentHealth = 0;
        
    }
}
