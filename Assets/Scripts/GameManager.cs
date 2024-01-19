using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField]
    private GameObject[] enemyList;
    private int wave = 1;

    private void Start()
    {
        SpawnNextWawe();
    }

    private void Update()
    {

    }

    private void SpawnNextWawe()
    {



        wave += 1;
    }

    private int EnemyRandomizer()
    {
        return 0;
    }
}
