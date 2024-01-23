using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField]
    private TextMeshProUGUI playerName;
    [SerializeField]
    private GameObject enemy;

    private void Start()
    {
        if (DataManager.Instance != null)
        {
            playerName.text = DataManager.Instance.playerName;
        }

        InvokeRepeating("SpawnNewEnemy", 0, 5);
    }
    private void FixedUpdate()
    {
        playerName.transform.rotation = Camera.main.transform.rotation;
    }

    private void SpawnNewEnemy()
    {
        if (GameObject.FindGameObjectsWithTag("Enemy").Length == 0)
        {
            Instantiate(enemy);
        }
    }
}
