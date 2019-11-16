using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDmg : MonoBehaviour
{

    public float TimeBetweenAttacks = 0.5f;
    public int attackDmg = 10;
    EnemyHealth enemyHealth;
    bool elfInRange;
    float timer;

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Elf")
        {
            enemyHealth = other.gameObject.GetComponent<EnemyHealth>();
            elfInRange = true;
        }
    }
    void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject.tag == "Elf")
        {
            elfInRange = false;
        }
    }

    void Update()
    {
        timer += Time.deltaTime;
        if (timer >= TimeBetweenAttacks && elfInRange)
        {
            Attack();
        }
    }
    void Attack()
    {
        timer = 0f;
        enemyHealth.TakeDamage(attackDmg);
    }
}
