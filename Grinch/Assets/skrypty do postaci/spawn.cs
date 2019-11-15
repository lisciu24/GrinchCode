using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawn : MonoBehaviour
{
    public GameObject[] players;
    public Vector3 minLocation;
    public vector3 maxLocation;
    
    
    // Start is called before the first frame update
    void Start()
    {
        foreach (GameObject player in players)
        {
            Instantiate(players,
                            new Vector3(Random.Range(minLocation.x, minLocation.x),
                                        Random.Range(minLoctaion.y, maxLocation.y)),
                            new Quanternion(0, 0, 0, 0));
        }
    }

    
}
