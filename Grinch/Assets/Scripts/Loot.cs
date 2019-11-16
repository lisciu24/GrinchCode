using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Loot : MonoBehaviour
{
    public GameObject red;
    public GameObject green;
    public GameObject blue;

    void OnDestroy()
    {
        GameObject go = null;
        int rand = Random.Range(1, 30);
        if(rand % 3 == 0)
        {
            go = Instantiate(red);
        }else if(rand % 3 == 1)
        {
            go = Instantiate(green);
        }else if(rand % 3 == 2)
        {
            go = Instantiate(blue);
        }

        go.transform.position = transform.position;
    }
}
