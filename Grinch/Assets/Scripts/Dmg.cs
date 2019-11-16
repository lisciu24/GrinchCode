using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dmg : MonoBehaviour
{
    public float timeBetweenAttacks = 0.5f;
    public short attackDamage = 10;
    GameObject player;
    GameObject choinka;
    Choinka choinkaHealth;
    PlayerHealth playerHealth;
    bool playerInRange;
    bool choinkaInRange;
    float timer;

    void Awake()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        playerHealth = player.GetComponent<PlayerHealth>();
        choinka = GameObject.FindGameObjectWithTag("Choinka");
        choinkaHealth = choinka.GetComponent<Choinka>();
    }

    void OnTriggerEnter2D(Collider2D other)
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
    void OnTriggerExit2D(Collider2D other)
    {
        if(other.gameObject == player)
        {
            playerInRange = false;
        }
    }
    
    void Update()
    {
        timer += Time.deltaTime;
        if(timer >=timeBetweenAttacks)
        {
            if (playerInRange)
            {
                timer = 0f;
                AttackPlayer();
            }
            else if (choinkaInRange)
            {
                timer = 0f;
                AttackChoinka();
            }
        }
    }
    void AttackPlayer()
    {
        playerHealth.TakeDamage(attackDamage);
    }

    void AttackChoinka()
    {
        choinkaHealth.TakeDamage(attackDamage);
    }
}
