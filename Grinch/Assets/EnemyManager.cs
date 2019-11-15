using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyManager : MonoBehaviour
{
    public Transform[] m_SpawnPoint;
    public Gameobject[] m_EnemyPrefab;

    // Start is called before the first frame update
    void Start()
    {
        SpawnNewEnemy();
    }

    void SpawnNearEnemy ()
    {
        Instantiate(m_EnemyPrefab, m_SpawnPoint[0].transform.position, Quaternion.identity);
    }
}
