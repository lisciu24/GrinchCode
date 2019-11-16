using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurretSelect : MonoBehaviour
{
    public GameObject turret;

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

            if(Physics.Raycast(ray, out hit, 100.0F))
            {
                if (hit.transform.gameObject == this.gameObject)
                {
                    if (turret.GetComponent<Turret>().CanBuy())
                    {
                        if (!transform.parent.transform.parent.gameObject.GetComponent<TurretSpawn>().busy)
                        {
                            GameObject go = Instantiate(turret);
                            go.transform.position = transform.parent.position;

                            turret.GetComponent<Turret>().Buy();

                            transform.parent.transform.parent.gameObject.GetComponent<TurretSpawn>().busy = true;
                            transform.parent.transform.parent.transform.parent.gameObject.GetComponent<TurretSpawns>().busy = false;
                            Destroy(transform.parent.gameObject);
                        }
                    }
                }
            }
        }
    }
}
