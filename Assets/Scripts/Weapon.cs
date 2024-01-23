using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{
    [SerializeField]
    private GameObject player;
    private DefaultCharacterClass characterClass;

    private void Start()
    {
        characterClass = player.GetComponent<DefaultCharacterClass>();
    }


    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Enemy"))
        {
            Enemy enemy = other.gameObject.GetComponent<Enemy>();
            enemy.enemyCurLife -= characterClass.RandomDamage();
        }
    }
}
