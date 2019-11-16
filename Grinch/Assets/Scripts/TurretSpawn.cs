﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurretSpawn : MonoBehaviour
{
    public GameObject turretSelect;
    private bool select = false;
    private GameObject instance;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit hit;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            if (Physics.Raycast(ray, out hit, 100.0F))
            {
                if (hit.transform != null)
                {
                    print("sadsad");

                    if (hit.transform.gameObject.tag == "TurretSpawn")
                    {
                        if (!select)
                        {
                            instance = Instantiate(turretSelect);
                            instance.transform.position = hit.transform.position;
                            select = true;
                        }
                    }
                    else
                    {
                        select = false;
                        Destroy(instance);
                    }
                }
            }
        }
    }
}