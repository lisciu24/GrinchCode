using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public Transform target;
    public float velocity;

    public int damage;

    // Update is called once per frame
    void Update()
    {
        if(target == null)
        {
            Destroy(this.gameObject);
            return;
        }
        transform.position = Vector3.MoveTowards(transform.position, target.position, velocity * Time.deltaTime);
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.tag == "Elf")
        {
            other.GetComponent<EnemyHealth>().TakeDamage(damage);
            Destroy(this.gameObject);
        }
    }
}
