using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnEnemyTrigger : MonoBehaviour
{
    private Enemy m_Enemy;

    private void Start()
    {
        m_Enemy = GetComponentInParent<Enemy>();
    }
    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.CompareTag("Player") && !m_Enemy.isAttacking)
        {
            StartCoroutine(m_Enemy.WeaponSwing());
        }
    }
}
