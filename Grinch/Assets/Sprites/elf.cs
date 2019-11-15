using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class elf : MonoBehaviour
{
    //living
    public short healthPoints = 0;

    //attack
    public short damage = 0;

    //move
    public float speed;

    private Transform target;

    // Start is called before the first frame update
    void Start()
    {
        terget = GameObjectWithTag("Choinka").Transform;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Veactor2.MoveTowards(trensform.position, target.position, speed * Time.deltaTime);
    }
}
