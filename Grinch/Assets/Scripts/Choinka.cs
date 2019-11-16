using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Choinka : MonoBehaviour
{
    public short healthPoints = 0;
    public GameObject end;

    public void TakeDamage(short damage)
    {
        healthPoints -= damage;
        if(healthPoints <= 0) {
            Instantiate(end).transform.position = new Vector3(0,0,0);
            enabled = false;
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
