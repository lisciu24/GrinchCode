using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    public GameObject Elf;
    public int wave;
    public float x;
    public float rand;
    public float minInterval;
    public float maxInterval;
    public float rest;
    private bool go;
    private float interval;
    private float timer;
    private float i;
    

    void Start()
    {
        interval = Random.Range(minInterval, maxInterval);
        i = 0;
        timer = 0;
        go = true;
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if (go)
        {
            if (i <= wave)
            {
                if (timer >= interval)
                {
                    Instantiate(Elf).transform.position = transform.position + new Vector3(0, Random.Range(-rand, rand), 0);
                    interval = Random.Range(minInterval, maxInterval);
                    timer = 0;
                    i++;
                }
            }
            else
            {
                i = 0;
                go = false;
                wave = Mathf.RoundToInt(x * wave);
            }
        }
        else
        {
            if(timer >= rest)
            {
                go = true;
            }
        }
    }
}
