﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grinch : MonoBehaviour
{
    //living
    public short healthPoints = 0;

    //resources
    public short redPresents = 0;
    public short bluePresents = 0;
    public short greenPresents = 0;

    //moving
    public bool move = false;
    public float velocity = 0F;
    private Vector3 target;

    //fighting
    public float attackDamage = 0F;
    public float attackSpeed = 0F;
    public float range = 0F;

    // Start is called before the first frame update
    void Start()
    {
        target = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        MoveToMouse();
    }

    void MoveToMouse()
    {
        if (Input.GetMouseButtonDown(0))
        {
            target = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            target.z = transform.position.z;
        }

        transform.position = Vector3.MoveTowards(transform.position, target, velocity * Time.deltaTime);
        move = (transform.position != target ? true : false);
    }
}