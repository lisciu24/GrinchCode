using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDmg : MonoBehaviour
{

    GameObject elf;
    public float TimeBetweenAttacks = 0.5f;
    public int attackDmg = 10;
    EnemyHealth enemyHealth;
    bool elfInRange;
    float timer;
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject == elf)
        {
            elfInRange = true;
        }
    }
    void OnTriggerExit(Collider other)
    {
        if (other.gameObject == elf)
        {
            elfInRange = false;
        }
    }

    void Update()
    {
        timer += Time.deltaTime;
        if (timer >= TimeBetweenAttacks && elfInRange && enemyHealth.currentHealth > 0)
        {
            Attack();
        }
    }
    void Attack()
    {
        timer = 0f;
        if (enemyHealth.currentHealth > 0)
        {
            enemyHealth.TakeDamage(attackDmg);
        }
    }
}
