using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurretAttack : MonoBehaviour
{
    public float attackDamage = 0F;
    public float attackSpeed = 0.5F;
    public float range = 0F;
    private float time = 0F;
    public GameObject bullet;

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;

        GameObject[] elfs = GameObject.FindGameObjectsWithTag("Elf");
        for (int i = 0; i < elfs.Length; i++)
        {
            if (Vector2.Distance(elfs[i].transform.position, transform.position) <= range)
            {
                Vector3 dir = elfs[i].transform.position - transform.position;
                float angle = (Mathf.Atan2(dir.y, dir.x) * Mathf.Rad2Deg) + 110;
                transform.rotation = Quaternion.AngleAxis(angle, new Vector3(0, 0, 1));

                if (time >= attackSpeed)
                {
                    {
                        GameObject go = Instantiate(bullet);
                        go.transform.position = transform.position;
                        go.GetComponent<Bullet>().target = elfs[i].gameObject;
                    }
                    time = 0F;
                }
            }
        }
    }
}
