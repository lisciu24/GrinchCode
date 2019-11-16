using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChoinkaHealth : MonoBehaviour
{

    public int startingHealth = 100;
    public int currentHealth;

    bool isDead;

    void Awake()
    {
        currentHealth = startingHealth;
    }

    // Update is called once per frame
  

    public void TakeDamage(int amount)
    {
        currentHealth -= amount;

        if (currentHealth <= 0 && !isDead)
        {
            Death();
        }
    }

    void Death()
    {
        isDead = true;
    }
}
