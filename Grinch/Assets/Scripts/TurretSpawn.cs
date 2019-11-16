using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurretSpawn : MonoBehaviour
{
    public GameObject turretSelect;
    public bool busy = false;
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
                    if (hit.transform.gameObject == this.gameObject)
                    {
                        if (!transform.parent.gameObject.GetComponent<TurretSpawns>().busy && !busy && !select)
                        {
                            instance = Instantiate(turretSelect);
                            instance.transform.position = hit.transform.position;

                            instance.transform.parent = transform;
                            select = true;
                            transform.parent.gameObject.GetComponent<TurretSpawns>().busy = true;
                        }
                    }
                }
            }
            else
            {
                if (select)
                {
                    transform.parent.gameObject.GetComponent<TurretSpawns>().busy = false;
                    select = false;
                    Destroy(instance);
                }
            }
        }
    }
}
