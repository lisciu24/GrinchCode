using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurretAttack : MonoBehaviour
{
    public int attackDamage;
    public float attackSpeed;
    public float range;
    private float time = 0F;
    public GameObject bullet;
    bool selected = false;
    GameObject target;

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;

        if (!selected)
        {
            GameObject[] elfs = GameObject.FindGameObjectsWithTag("Elf");
            for (int i = 0; i < elfs.Length; i++)
            {
                if (Vector2.Distance(elfs[i].transform.position, transform.position) <= range)
                {
                    target = elfs[i];
                    selected = true;
                }
            }
        }

        if (selected)
        {
            if(target == null || Vector2.Distance(target.transform.position, transform.position) > range)
            {
                selected = false;
                return;
            }

            Vector3 dir = target.transform.position - transform.position;
            float angle = (Mathf.Atan2(dir.y, dir.x) * Mathf.Rad2Deg) + 110;
            transform.rotation = Quaternion.AngleAxis(angle, new Vector3(0, 0, 1));

            if (time >= attackSpeed)
            {
                {
                    GameObject go = Instantiate(bullet);
                    go.transform.position = transform.position;
                    go.GetComponent<Bullet>().target = target.transform;
                    go.GetComponent<Bullet>().damage = attackDamage;
                }
                time = 0F;
            }
        }
    }
}
