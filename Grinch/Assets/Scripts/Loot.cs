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
        int rand = Random.Range(1, 30);
        if(rand % 3 == 0)
        {
            Instantiate(red);
        }else if(rand % 3 == 1)
        {
            Instantiate(green);
        }else if(rand % 3 == 2)
        {
            Instantiate(blue);
        }
    }
}
