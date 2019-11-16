using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Choinka : MonoBehaviour
{
    public short currentHealth = 0;
    public GameObject end;

    public void TakeDamage(short damage)
    {
        currentHealth -= damage;
        if(currentHealth <= 0) {
            Instantiate(end).transform.position = new Vector3(0,0,0);
            enabled = false;
        }
    }
}
