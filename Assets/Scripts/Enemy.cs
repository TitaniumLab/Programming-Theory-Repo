using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.UI;

public class Enemy : MonoBehaviour
{
    [SerializeField]
    private int enemyMaxLife = 10;
    private int _enemyCurLife;
    private int minDamage = 1;
    private int maxDamage = 3;
    public int enemyCurLife
    {
        get { return _enemyCurLife; }
        set
        {
            if (value > enemyMaxLife)
                enemyCurLife = enemyMaxLife;
            else if (value <= 0)
                Destroy(gameObject);
            else
            {
                _enemyCurLife = value;
                slider.value = _enemyCurLife;
            }
        }
    }

    private Slider slider;

    private GameObject player;
    public bool isAttacking = false;
    private NavMeshAgent agent;
    [SerializeField]
    private GameObject weapon;


    private void Start()
    {
        player = GameObject.Find("Default Player Class");
        _enemyCurLife = enemyMaxLife;
        agent = GetComponent<NavMeshAgent>();

        slider = GetComponentInChildren<Slider>();
        slider.maxValue = enemyMaxLife;
        slider.value = _enemyCurLife;
    }

    private void Update()
    {
        if (!isAttacking)
        {
            agent.destination = player.transform.position;
        }
        slider.transform.rotation = Camera.main.transform.rotation;
    }




    public IEnumerator WeaponSwing()
    {
        isAttacking = true;
        weapon.SetActive(true);
        Quaternion startRotation = weapon.transform.rotation;

        weapon.transform.LookAt(player.transform);
        for (int i = 0; i < 20; i++)
        {
            weapon.transform.Rotate(Vector3.right, 5);
            Quaternion keepDirection = weapon.transform.rotation;
            yield return new WaitForSeconds(0.02f);
            weapon.transform.rotation = keepDirection;
        }
        weapon.transform.rotation = startRotation;
        weapon.SetActive(false);
        isAttacking = false;
    }

    public int RandomDamage()
    {
        return Random.Range(minDamage, maxDamage + 1);
    }

}
