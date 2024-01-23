using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyWeapon : MonoBehaviour
{

    private Enemy _enemy;

    private void Start()
    {
        _enemy = GetComponentInParent<Enemy>();
    }


    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            DefaultCharacterClass player = other.gameObject.GetComponent<DefaultCharacterClass>();
            player.currentLife -= _enemy.RandomDamage();
        }
    }
}
