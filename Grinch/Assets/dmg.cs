using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dmg : MonoBehaviour
{
    public float timeBetweenAttacks = 0.5f;
    public int attackDamage = 10;
    GameObject player;
    GameObject choinka;
    ChoinkaHealth choinkaHealth;
    PlayerHealth playerHealth;
    EnemyHealth enemyHealth;
    bool playerInRange;
    bool choinkaInRange;
    float timer;
    EnemySpeed enemySpeed;

    void Awake()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        playerHealth = player.GetComponent<PlayerHealth>();
        enemyHealth = GetComponent<EnemyHealth>();
        choinka = GameObject.FindGameObjectWithTag("Choinka");
        choinkaHealth = choinka.GetComponent<ChoinkaHealth>();
    }

    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject == player)
        {
            playerInRange = true;
        }
        if(other.gameObject == choinka)
        {
            choinkaInRange = true;
        }
    }
    void OnTriggerExit(Collider other)
    {
        if(other.gameObject == player)
        {
            playerInRange = false;
        }
    }
    
    void Update()
    {
        timer += Time.deltaTime;
        if(timer >=timeBetweenAttacks && playerInRange && enemyHealth.currentHealth > 0)
        {
            Attack();
        }
        if(timer <= timeBetweenAttacks && choinkaInRange && choinkaHealth.currentHealth > 0)
        {
            Attack();
        }
        
    }
    void Attack()
    {
        timer = 0f;
        if(playerHealth.currentHealth > 0)
        {
            playerHealth.TakeDamage(attackDamage);
        }
        if(choinkaHealth.currentHealth > 0)
        {
            choinkaHealth.TakeDamage(attackDamage);
        }
    }
}
