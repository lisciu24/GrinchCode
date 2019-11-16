using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public GameObject target;
    public float velocity = 0F;

    public float damage = 0F;

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, target.transform.position, velocity * Time.deltaTime);
        if(transform.position == target.transform.position)
        {
            Destroy(this.gameObject);
        }
    }
}
